using Helperland.Core;
using Helperland.Data;
using Helperland.Models;
using Helperland.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HelperlandContext _helperlandContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, HelperlandContext helperlandContext, IHostingEnvironment hostingEnvironment, IConfiguration configuration)
        {
            _logger = logger;
            this._helperlandContext = helperlandContext;
            this._hostingEnvironment = hostingEnvironment;
            this._configuration = configuration;
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
