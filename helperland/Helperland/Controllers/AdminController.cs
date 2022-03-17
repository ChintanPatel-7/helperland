using Helperland.Core;
using Helperland.Enums;
using Helperland.Models;
using Helperland.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    [CookieHelper]
    [SessionHelper(userType: UserTypeEnum.Admin)]
    public class AdminController : Controller
    {
        private readonly IAdminControllerRepository _adminControllerRepository;
        private readonly IConfiguration _configuration;

        public AdminController(IAdminControllerRepository adminControllerRepository, IConfiguration configuration)
        {
            this._adminControllerRepository = adminControllerRepository;
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetUserList()
        {
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

                var searchUserName = Request.Form["searchUserName"].FirstOrDefault();
                var searchUserType = Request.Form["searchUserType"].FirstOrDefault();
                var searchPhoneNumber = Request.Form["searchPhoneNumber"].FirstOrDefault();
                var searchZipcode = Request.Form["searchZipcode"].FirstOrDefault();
                var searchRegistrationStartDate = Request.Form["searchRegistrationStartDate"].FirstOrDefault();
                var searchRegistrationEndDate = Request.Form["searchRegistrationEndDate"].FirstOrDefault();

                IEnumerable<User> userList = _adminControllerRepository.GetUserList();

                if (!string.IsNullOrEmpty(searchUserName))
                {
                    userList = userList.Where(x => (x.FirstName.ToString().ToLower() + " " + x.LastName.ToString().ToLower()).Contains(searchUserName.ToLower()));
                }

                if (!string.IsNullOrEmpty(searchUserType))
                {
                    userList = userList.Where(x => x.UserTypeId.ToString().Contains(searchUserType));
                }

                if (!string.IsNullOrEmpty(searchPhoneNumber))
                {
                    userList = userList.Where(x => x.Mobile.ToString().Contains(searchPhoneNumber));
                }

                if (!string.IsNullOrEmpty(searchZipcode))
                {
                    userList = userList.Where(x => !string.IsNullOrEmpty(x.ZipCode) && x.ZipCode.Contains(searchZipcode));
                }

                if (!string.IsNullOrEmpty(searchRegistrationStartDate))
                {
                    DateTime startDate = Convert.ToDateTime(searchRegistrationStartDate);
                    userList = userList.Where(x => x.CreatedDate > startDate);
                }

                if (!string.IsNullOrEmpty(searchRegistrationEndDate))
                {
                    DateTime endDate = Convert.ToDateTime(searchRegistrationEndDate);
                    userList = userList.Where(x => x.CreatedDate < endDate);
                }

                var sortOrder = sortColumn + "_" + sortColumnDirection;

                switch (sortOrder)
                {
                    case "UserId_asc":
                        userList = userList.OrderBy(s => s.UserId);
                        break;
                    case "UserId_desc":
                        userList = userList.OrderByDescending(s => s.UserId);
                        break;
                    case "UserName_asc":
                        userList = userList.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
                        break;
                    case "UserName_desc":
                        userList = userList.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);
                        break;
                    case "CreatedDate_asc":
                        userList = userList.OrderBy(s => s.CreatedDate);
                        break;
                    case "CreatedDate_desc":
                        userList = userList.OrderByDescending(s => s.CreatedDate);
                        break;
                    case "UserType_asc":
                        userList = userList.OrderBy(s => (int)s.UserTypeId == 1 ? "Admin" : (int)s.UserTypeId == 2 ? "Service Provider" : "Customer");
                        break;
                    case "UserType_desc":
                        userList = userList.OrderByDescending(s => (int)s.UserTypeId == 1 ? "Admin" : (int)s.UserTypeId == 2 ? "Service Provider" : "Customer");
                        break;
                    case "Mobile_asc":
                        userList = userList.OrderBy(s => s.Mobile);
                        break;
                    case "Mobile_desc":
                        userList = userList.OrderByDescending(s => s.Mobile);
                        break;
                    case "Zipcode_asc":
                        userList = userList.OrderBy(s => s.ZipCode);
                        break;
                    case "Zipcode_desc":
                        userList = userList.OrderByDescending(s => s.ZipCode);
                        break;
                    case "Status_asc":
                        userList = userList.OrderBy(s => (bool)s.IsActive == true ? "Active" : "Inactive");
                        break;
                    case "Status_desc":
                        userList = userList.OrderByDescending(s => (bool)s.IsActive == true ? "Active" : "Inactive");
                        break;
                    default:
                        userList = userList.OrderBy(s => s.UserId);
                        break;
                }

                recordsTotal = userList.Count();
                var data = userList.Skip(skip).Take(pageSize).ToList();

                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult ServiceRequests()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetServiceRequestList()
        {
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

                //var searchUserName = Request.Form["searchUserName"].FirstOrDefault();
                //var searchUserType = Request.Form["searchUserType"].FirstOrDefault();
                //var searchPhoneNumber = Request.Form["searchPhoneNumber"].FirstOrDefault();
                //var searchZipcode = Request.Form["searchZipcode"].FirstOrDefault();
                //var searchRegistrationStartDate = Request.Form["searchRegistrationStartDate"].FirstOrDefault();
                //var searchRegistrationEndDate = Request.Form["searchRegistrationEndDate"].FirstOrDefault();

                IEnumerable<ServiceRequest> serviceRequestList = _adminControllerRepository.GetServiceRequestList();

                //if (!string.IsNullOrEmpty(searchUserName))
                //{
                //    userList = userList.Where(x => (x.FirstName.ToString().ToLower() + " " + x.LastName.ToString().ToLower()).Contains(searchUserName.ToLower()));
                //}

                //if (!string.IsNullOrEmpty(searchUserType))
                //{
                //    userList = userList.Where(x => x.UserTypeId.ToString().Contains(searchUserType));
                //}

                //if (!string.IsNullOrEmpty(searchPhoneNumber))
                //{
                //    userList = userList.Where(x => x.Mobile.ToString().Contains(searchPhoneNumber));
                //}

                //if (!string.IsNullOrEmpty(searchZipcode))
                //{
                //    userList = userList.Where(x => !string.IsNullOrEmpty(x.ZipCode) && x.ZipCode.Contains(searchZipcode));
                //}

                //if (!string.IsNullOrEmpty(searchRegistrationStartDate))
                //{
                //    DateTime startDate = Convert.ToDateTime(searchRegistrationStartDate);
                //    userList = userList.Where(x => x.CreatedDate > startDate);
                //}

                //if (!string.IsNullOrEmpty(searchRegistrationEndDate))
                //{
                //    DateTime endDate = Convert.ToDateTime(searchRegistrationEndDate);
                //    userList = userList.Where(x => x.CreatedDate < endDate);
                //}

                var sortOrder = sortColumn + "_" + sortColumnDirection;

                switch (sortOrder)
                {
                    case "ServiceRequestId_asc":
                        serviceRequestList = serviceRequestList.OrderBy(s => s.ServiceRequestId);
                        break;
                    case "ServiceRequestId_desc":
                        serviceRequestList = serviceRequestList.OrderByDescending(s => s.ServiceRequestId);
                        break;
                    case "ServiceStartDate_asc":
                        serviceRequestList = serviceRequestList.OrderBy(s => s.ServiceStartDate);
                        break;
                    case "ServiceStartDate_desc":
                        serviceRequestList = serviceRequestList.OrderByDescending(s => s.ServiceStartDate);
                        break;
                    case "Customer_asc":
                        serviceRequestList = serviceRequestList.OrderBy(s => s.User.FirstName).ThenBy(s => s.User.LastName);
                        break;
                    case "Customer_desc":
                        serviceRequestList = serviceRequestList.OrderByDescending(s => s.User.FirstName).ThenBy(s => s.User.LastName);
                        break;
                    case "ServiceProvider_asc":
                        serviceRequestList = serviceRequestList.OrderBy(s => s.ServiceProvider == null ? string.Empty : s.ServiceProvider.FirstName).ThenBy(s => s.ServiceProvider == null ? string.Empty : s.ServiceProvider.LastName);
                        break;
                    case "ServiceProvider_desc":
                        serviceRequestList = serviceRequestList.OrderByDescending(s => s.ServiceProvider == null ? string.Empty : s.ServiceProvider.FirstName).ThenBy(s => s.ServiceProvider == null ? string.Empty : s.ServiceProvider.LastName);
                        break;
                    case "Status_asc":
                        serviceRequestList = serviceRequestList.OrderBy(s => (s.Status == (int)ServiceRequestStatusEnum.New ? "New" : (s.Status == (int)ServiceRequestStatusEnum.Cancelled ? "Cancelled" : (s.Status == (int)ServiceRequestStatusEnum.Completed ? "Completed" : "Pending"))));
                        break;
                    case "Status_desc":
                        serviceRequestList = serviceRequestList.OrderByDescending(s => (s.Status == (int)ServiceRequestStatusEnum.New ? "New" : (s.Status == (int)ServiceRequestStatusEnum.Cancelled ? "Cancelled" : (s.Status == (int)ServiceRequestStatusEnum.Completed ? "Completed" : "Pending"))));
                        break;
                    default:
                        serviceRequestList = serviceRequestList.OrderByDescending(s => s.ServiceProviderId);
                        break;
                }

                recordsTotal = serviceRequestList.Count();
                var data = serviceRequestList.Skip(skip).Take(pageSize).ToList();

                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
