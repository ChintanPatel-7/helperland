using Helperland.Core;
using Helperland.Data;
using Helperland.Enums;
using Helperland.Models;
using Helperland.Repository;
using Helperland.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    [CookieHelper]
    [SessionHelper(userType: UserTypeEnum.Customer)]
    public class CustomerController : Controller
    {
        private readonly ICustomerControllerRepository _customerControllerRepository;
        private readonly IConfiguration _configuration;
        private readonly HelperlandContext _helperlandContext;

        public CustomerController(ICustomerControllerRepository customerControllerRepository, IConfiguration configuration, 
            HelperlandContext helperlandContext)
        {
            this._customerControllerRepository = customerControllerRepository;
            this._configuration = configuration;
            this._helperlandContext = helperlandContext;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetCurrentServiceRequestList()
        {
            var user = HttpContext.Session.GetString("User");
            SessionUser sessionUser = new SessionUser();

            if (user != null)
            {
                sessionUser = JsonConvert.DeserializeObject<SessionUser>(user);
            }

            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var serviceRequest = _customerControllerRepository.GetCurrentServiceRequestByCustomerId(Convert.ToInt32(sessionUser.UserID));

                var sortOrder = sortColumn + "_" + sortColumnDirection;

                switch (sortOrder)
                {
                    case "ServiceRequestId_asc":
                        serviceRequest = serviceRequest.OrderBy(s => s.ServiceRequestId);
                        break;
                    case "ServiceRequestId_desc":
                        serviceRequest = serviceRequest.OrderByDescending(s => s.ServiceRequestId);
                        break;
                    case "ServiceDateTime_asc":
                        serviceRequest = serviceRequest.OrderBy(s => s.ServiceStartDate);
                        break;
                    case "ServiceDateTime_desc":
                        serviceRequest = serviceRequest.OrderByDescending(s => s.ServiceStartDate);
                        break;
                    case "ServiceProvider_asc":
                        serviceRequest = serviceRequest.OrderBy(s => s.User == null ? string.Empty : s.User.FirstName).ThenBy(s => s.User == null ? string.Empty : s.User.LastName);  //check once for sorting
                        break;
                    case "ServiceProvider_desc":
                        serviceRequest = serviceRequest.OrderByDescending(s => s.User == null ? string.Empty : s.User.FirstName).ThenBy(s => s.User == null ? string.Empty : s.User.LastName);
                        break;
                    case "TotalCost_asc":
                        serviceRequest = serviceRequest.OrderBy(s => s.TotalCost);
                        break;
                    case "TotalCost_desc":
                        serviceRequest = serviceRequest.OrderByDescending(s => s.TotalCost);
                        break;
                    default:
                        serviceRequest = serviceRequest.OrderBy(s => s.ServiceRequestId);
                        break;
                }

                recordsTotal = serviceRequest.Count();
                var data = serviceRequest.Skip(skip).Take(pageSize).ToList();

                foreach (ServiceRequest temp in data)
                {
                    if (temp.ServiceProviderId != null)
                    {
                        temp.Ratings = _customerControllerRepository.GetRatingsByServiceProviderId(temp.ServiceProviderId);
                    }
                }

                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        [HttpPost]
        public JsonResult GetServiceRequest(int serviceRequestId)
        {
            ServiceRequest serviceRequest = _customerControllerRepository.GetServiceRequest(serviceRequestId);

            String serviceRequestExtraName = "";

            foreach (ServiceRequestExtra serviceRequestExtra in serviceRequest.ServiceRequestExtras)
            {
                serviceRequestExtraName = serviceRequestExtraName + ", " + Enum.GetName(typeof(ExtraServiceEnum), serviceRequestExtra.ServiceExtraId);
            }

            if (serviceRequestExtraName.Length > 2)
            {
                serviceRequestExtraName = serviceRequestExtraName.Remove(0, 2);
            }
            else
            {
                serviceRequestExtraName = "-";
            }

            var jsonData = new { data = serviceRequest, extraServiceRequest = serviceRequestExtraName };
            return Json(jsonData);
        }

        [HttpPost]
        public JsonResult UpdateRescheduleServiceRequest([FromBody] ServiceRequestViewModel model)
        {
            ServiceRequest serviceRequest = _customerControllerRepository.GetServiceRequest(model.ServiceRequestId);

            DateTime newServiceRequestStartDateTime = Convert.ToDateTime(model.ServiceStartDate + " " + model.ServiceStartTime);
            DateTime newServiceRequestEndDateTime = newServiceRequestStartDateTime.AddMinutes(serviceRequest.ServiceHours * 60);

            if (serviceRequest.ServiceProviderId != null)
            {
                List<ServiceRequest> serviceRequestList = _customerControllerRepository.GetFutureServiceRequestByServiceProviderId(Convert.ToInt32(serviceRequest.ServiceProviderId));

                Boolean serviceRequestConflict = false;

                string errorMessage = "";

                foreach (ServiceRequest temp in serviceRequestList)
                {
                    if(serviceRequest.ServiceRequestId != temp.ServiceRequestId)
                    {
                        DateTime serviceRequestStartDateTime = temp.ServiceStartDate;
                        DateTime serviceRequestEndDateTime = serviceRequestStartDateTime.AddMinutes(temp.ServiceHours * 60);

                        if (serviceRequestStartDateTime <= newServiceRequestEndDateTime && newServiceRequestStartDateTime <= serviceRequestEndDateTime)
                        {
                            serviceRequestConflict = true;
                            errorMessage = "Another service request has been assigned to the service provider on " + serviceRequestStartDateTime.ToShortDateString()
                                + " from " + serviceRequestStartDateTime.ToShortTimeString() + " to " + serviceRequestEndDateTime.ToShortTimeString() + ". Either choose another date or pick up a different time slot";
                            break;
                        }
                    }
                }

                if(serviceRequestConflict == true)
                {
                    return Json(new SingeEntity<ServiceRequestViewModel> { Result = model, Status = "Error", ErrorMessage = errorMessage });
                }
            }

            var user = HttpContext.Session.GetString("User");
            SessionUser sessionUser = new SessionUser();

            if (user != null)
            {
                sessionUser = JsonConvert.DeserializeObject<SessionUser>(user);
            }

            serviceRequest.ServiceStartDate = newServiceRequestStartDateTime;
            serviceRequest.ModifiedBy = Convert.ToInt32(sessionUser.UserID);
            serviceRequest.ModifiedDate = DateTime.Now;

            _customerControllerRepository.UpdateServiceRequest(serviceRequest);

            if (serviceRequest.ServiceProviderId != null)
            {
                User sp = _customerControllerRepository.GetUserByPK(Convert.ToInt32(serviceRequest.ServiceProviderId));

                MailHelper mailHelper = new MailHelper(_configuration);
                EmailModel emailModel = new EmailModel();

                emailModel.To = sp.Email;
                emailModel.Subject = "Reschedule ServiceRequest";
                emailModel.Body = "Service Request " + serviceRequest.ServiceRequestId + " has been rescheduled by customer. New date and time are " + 
                    serviceRequest.ServiceStartDate.ToShortDateString() + " " + serviceRequest.ServiceStartDate.ToShortTimeString() + ".";

                mailHelper.SendServiceRequestToServiceProvider(emailModel);
            }

            return Json(new SingeEntity<ServiceRequestViewModel> { Result = model, Status = "ok", ErrorMessage = null });
        }

        [HttpPost]
        public JsonResult CancelServiceRequest([FromBody] ServiceRequestViewModel model)
        {
            ServiceRequest serviceRequest = _customerControllerRepository.GetServiceRequest(model.ServiceRequestId);

            var user = HttpContext.Session.GetString("User");
            SessionUser sessionUser = new SessionUser();

            if (user != null)
            {
                sessionUser = JsonConvert.DeserializeObject<SessionUser>(user);
            }

            serviceRequest.Comments = model.Comments;
            serviceRequest.Status = (int)ServiceRequestStatusEnum.Cancelled;
            serviceRequest.ModifiedBy = Convert.ToInt32(sessionUser.UserID);
            serviceRequest.ModifiedDate = DateTime.Now;

            _customerControllerRepository.UpdateServiceRequest(serviceRequest);

            if (serviceRequest.ServiceProviderId != null)
            {
                User sp = _customerControllerRepository.GetUserByPK(Convert.ToInt32(serviceRequest.ServiceProviderId));

                MailHelper mailHelper = new MailHelper(_configuration);
                EmailModel emailModel = new EmailModel();

                emailModel.To = sp.Email;
                emailModel.Subject = "Cancel ServiceRequest";
                emailModel.Body = "Service Request " + serviceRequest.ServiceRequestId + " cancelled by customer.";

                mailHelper.SendServiceRequestToServiceProvider(emailModel);
            }

            return Json(new SingeEntity<ServiceRequestViewModel> { Result = model, Status = "ok", ErrorMessage = null });
        }

        public IActionResult ServiceHistory()
        {
            return View();
        }

        public IActionResult MyAccount()
        {
            return View();
        }

    }
}
