using Helperland.Core;
using Helperland.Data;
using Helperland.Enums;
using Helperland.Models;
using Helperland.Repository;
using Helperland.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    [CookieHelper]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HelperlandContext _helperlandContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        private readonly IUserAddressRepository _userAddressRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IUserRepository _userRepository;
        private readonly IServiceRequestRepository _serviceRequestRepository;
        private readonly IServiceRequestAddressRepository _serviceRequestAddressRepository;
        private readonly IServiceRequestExtraRepository _serviceRequestExtraRepository;
        private readonly IStateRepository _stateRepository;

        public HomeController(ILogger<HomeController> logger, HelperlandContext helperlandContext,
            IHostingEnvironment hostingEnvironment, IConfiguration configuration, IUserAddressRepository userAddressRepository,
            ICityRepository cityRepository, IUserRepository userRepository, IServiceRequestRepository serviceRequestRepository, 
            IServiceRequestAddressRepository serviceRequestAddressRepository, IServiceRequestExtraRepository serviceRequestExtraRepository,
            IStateRepository stateRepository)
        {
            _logger = logger;
            this._helperlandContext = helperlandContext;
            this._hostingEnvironment = hostingEnvironment;
            this._configuration = configuration;
            this._userAddressRepository = userAddressRepository;
            this._cityRepository = cityRepository;
            this._userRepository = userRepository;
            this._serviceRequestRepository = serviceRequestRepository;
            this._serviceRequestAddressRepository = serviceRequestAddressRepository;
            this._serviceRequestExtraRepository = serviceRequestExtraRepository;
            this._stateRepository = stateRepository;
        }

        public IActionResult Index()
        {
            if(TempData["OpenModel"] != null)
            {
                @ViewBag.OpenModel = TempData["OpenModel"].ToString();
            }
            ViewBag.navbar = "transparentNavbar";
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult faq()
        {
            return View();
        }

        public IActionResult prices()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                ContactU contactU = new ContactU
                {
                    Name = model.FirstName + " " + model.LastName,
                    PhoneNumber = model.MobileNumber,
                    Email = model.EmailAddress,
                    Subject = model.Subject,
                    Message = model.Message
                };

                string attachmentFilePath = "";

                if (model.Attachment != null)
                {
                    string uniqueAttachmentName = null;
                    string uploadsAttachmentFolder = Path.Combine(_hostingEnvironment.WebRootPath, "upload\\contact-us-attachment");
                    uniqueAttachmentName = Guid.NewGuid().ToString() + "_" + model.Attachment.FileName;
                    attachmentFilePath = Path.Combine(uploadsAttachmentFolder, uniqueAttachmentName);
                    using (var fileStream = new FileStream(attachmentFilePath, FileMode.Create))
                    {
                        model.Attachment.CopyTo(fileStream);
                    }

                    contactU.UploadFileName = uniqueAttachmentName;
                }

                _helperlandContext.ContactUs.Add(contactU);
                _helperlandContext.SaveChanges();

                //Send email to admin

                EmailModel emailModel = new EmailModel
                {
                    Subject = contactU.Subject,
                    Body = contactU.Message,
                    Attachment = attachmentFilePath
                };

                MailHelper mailHelper = new MailHelper(_configuration);
                mailHelper.SendContactUsDetail(emailModel);

                ModelState.Clear();

                return View();
            }

            return View(model);
        }

        public IActionResult OpenLoginModel()
        {
            TempData["OpenModel"] = "Login";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult OpenForgotPasswordModel()
        {
            TempData["OpenModel"] = "ForgotPassword";
            return RedirectToAction("Index", "Home");
        }

        [SessionHelper(userType: UserTypeEnum.Customer)]
        public IActionResult BookService()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CheckPostalCode(string postalCode)
        {
            List<User> user = _userRepository.GetUserByPostalCode(postalCode);
            bool IsServiceProviderAvailable = false;
            if(user.Any())
            {
                IsServiceProviderAvailable = true;
            }
            return Json(IsServiceProviderAvailable);
        }

        public IActionResult GetCustomerAddressList(int userId)
        {
            List<UserAddress> userAddresseList = _userAddressRepository.GetUserAddress(userId);
            return View("BookServiceCustomerAddressList", userAddresseList);
        }

        [HttpPost]
        public JsonResult GetCitiesByPostalCode(string postalCode)
        {
            List<City> cities = _cityRepository.GetCitiesByPostalCode(postalCode);
            return Json(cities);
        }

        [HttpPost]
        public JsonResult AddCustomerAddress([FromBody] UserAddressViewModel userAddressViewModel)
        {
            string user = HttpContext.Session.GetString("User");
            SessionUser sessionUser = new SessionUser();
            if (user != null)
            {
                sessionUser = JsonConvert.DeserializeObject<SessionUser>(user);
            }

            State state = _stateRepository.GetStateByCityName(userAddressViewModel.City.ToString().Trim());

            UserAddress userAddress = new UserAddress
            {
                AddressLine1 = userAddressViewModel.StreetName.ToString().Trim(),
                AddressLine2 = userAddressViewModel.HouseNumber.ToString().Trim(),
                PostalCode = userAddressViewModel.PostalCode,
                City = userAddressViewModel.City.ToString().Trim(),
                State = state.StateName,
                Mobile = userAddressViewModel.PhoneNumber,
                UserId = Convert.ToInt32(sessionUser.UserID)
            };
            userAddress = _userAddressRepository.AddUserAddress(userAddress);
            return Json(userAddress);
        }

        [HttpPost]
        public JsonResult BookCustomerServiceRequest([FromBody] ServiceRequestViewModel model)
        {
            ServiceRequest serviceRequest = new ServiceRequest
            {
                UserId = model.UserId,
                ServiceId = 0,
                ServiceStartDate = Convert.ToDateTime(model.ServiceStartDate.ToString().Trim() + " " + model.ServiceStartTime.ToString().Trim()),
                ZipCode = model.ZipCode.ToString().Trim(),
                ServiceHourlyRate = model.ServiceHourlyRate,
                ServiceHours = model.ServiceHours,
                ExtraHours = model.ExtraHours,
                SubTotal = Convert.ToDecimal(model.SubTotal),
                Discount = 0,
                TotalCost = Convert.ToDecimal(model.TotalCost),
                Comments = model.Comments.ToString().Trim(),
                PaymentDue = false,
                HasPets = model.HasPets,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Distance = 0,
                RecordVersion = Guid.NewGuid()
            };

            _serviceRequestRepository.Add(serviceRequest);

            model.ServiceRequestId = serviceRequest.ServiceRequestId;

            UserAddress userAddress = _userAddressRepository.SelectByPK(Convert.ToInt32(model.UserAddressId));

            ServiceRequestAddress serviceRequestAddress = new ServiceRequestAddress
            {
                ServiceRequestId = serviceRequest.ServiceRequestId,
                AddressLine1 = userAddress.AddressLine1,
                AddressLine2 = userAddress.AddressLine2,
                City = userAddress.City,
                State = userAddress.State,
                PostalCode = userAddress.PostalCode,
                Mobile = userAddress.Mobile,
                Email = userAddress.Email
            };

            _serviceRequestAddressRepository.Add(serviceRequestAddress);

            ServiceRequestExtra serviceRequestExtra = new ServiceRequestExtra
            {
                ServiceRequestId = serviceRequest.ServiceRequestId
            };

            foreach (string extraService in model.ExtraServicesName)
            {
                serviceRequestExtra.ServiceRequestExtraId = 0;
                serviceRequestExtra.ServiceExtraId = Convert.ToInt32((ExtraServiceEnum)System.Enum.Parse(typeof(ExtraServiceEnum), extraService));
                _serviceRequestExtraRepository.Add(serviceRequestExtra);
            }

            return Json(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
