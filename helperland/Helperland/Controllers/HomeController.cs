using Helperland.Data;
using Helperland.Models;
using Helperland.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        public HomeController(ILogger<HomeController> logger, HelperlandContext helperlandContext, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            this._helperlandContext = helperlandContext;
            this._hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.navbar = "transparentNavbar";
            ViewBag.displayFlag = true;
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

                if(model.Attachment != null)
                {
                    string uniqueAttachmentName = null;
                    string uploadsAttachmentFolder = Path.Combine(_hostingEnvironment.WebRootPath, "upload\\contact-us-attachment");
                    uniqueAttachmentName = Guid.NewGuid().ToString() + "_" + model.Attachment.FileName;
                    string attachmentFilePath = Path.Combine(uploadsAttachmentFolder, uniqueAttachmentName);
                    using (var fileStream = new FileStream(attachmentFilePath, FileMode.Create))
                    {
                        model.Attachment.CopyTo(fileStream);
                    }

                    contactU.UploadFileName = uniqueAttachmentName;
                }

                _helperlandContext.ContactUs.Add(contactU);
                _helperlandContext.SaveChanges();

                return RedirectToAction();
            }

            return View(model);
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
