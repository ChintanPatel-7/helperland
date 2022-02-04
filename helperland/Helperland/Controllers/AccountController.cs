using Helperland.Core;
using Helperland.Data;
using Helperland.Enums;
using Helperland.Models;
using Helperland.ViewModels;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class AccountController : Controller
    {
        private readonly HelperlandContext _helperlandContext;
        private readonly IConfiguration _configuration;
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly string _Key = "MSIHELPERLAND";
        private User _user;

        public AccountController(HelperlandContext helperlandContext, IConfiguration configuration, IHostingEnvironment hostingEnvironment, IDataProtectionProvider dataProtectionProvider)
        {
            this._helperlandContext = helperlandContext;
            this._configuration = configuration;
            this._hostingEnvironment = hostingEnvironment;
            this._dataProtectionProvider = dataProtectionProvider;
        }

        [HttpPost]
        public async Task<IActionResult> LoginModal(LoginAndForgotPasswordViewModel model)
        {
            if(ModelState.IsValid)
            {
                _user = await _helperlandContext.Users.FirstOrDefaultAsync(l => l.Email == model.Login.Email && l.Password == model.Login.Password);

                if (_user != null && _user.IsApproved == true)
                {
                    int userTypeId = Convert.ToInt32(_user.UserTypeId);

                    SessionUser sessionUser = new SessionUser
                    {
                        UserID = _user.UserId.ToString(),
                        UserName = _user.FirstName + " " + _user.LastName,
                        UserType = ((UserTypeEnum)userTypeId).ToString()
                    };

                    HttpContext.Session.SetString("User", JsonConvert.SerializeObject(sessionUser));

                    if (_user.UserTypeId == (int)UserTypeEnum.Admin)
                    {
                        return RedirectToAction("UserManagement", "Admin");
                    }
                    else if (_user.UserTypeId == (int)UserTypeEnum.ServiceProvider)
                    {
                        return RedirectToAction("UpcomingService", "ServiceProvider");
                    }
                    else if (_user.UserTypeId == (int)UserTypeEnum.Customer)
                    {
                        return RedirectToAction("ServiceHistory", "Customer");
                    }
                }
                else if(_user != null && _user.IsApproved == false)
                {
                    TempData["ErrorMessage"] = "You have not yet approved by Admin";
                }
                else
                {
                    TempData["ErrorMessage"] = "Username or password is invalid";
                }
            }

            //for home page & open Login Model to show errors
            ViewBag.navbar = "transparentNavbar";
            ViewBag.OpenModel = "Login";

            return View("~/Views/home/index.cshtml", model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegistration(UserRegistrationViewModel model)
        {
            if(ModelState.IsValid)
            {
                _user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.MobileNumber,
                    UserTypeId = (int)UserTypeEnum.Customer,
                    CreatedDate = DateTime.Now,
                    IsApproved = true
                };

                _helperlandContext.Users.Add(_user);
                _helperlandContext.SaveChanges();

                TempData["SuccessMessage"] = "Register Successfully.";

                return RedirectToAction();
            }

            return View("Index",model);
        }

        public IActionResult BecomeAPro()
        {
            ViewBag.navbar = "transparentNavbar";
            ViewBag.hideFlag = true;
            return View();
        }

        //BecomeAPro post method
        [HttpPost]
        public IActionResult ServiceProviderRegistration(UserRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _user = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.MobileNumber,
                    UserTypeId = (int)UserTypeEnum.ServiceProvider,
                    CreatedDate = DateTime.Now,
                    IsApproved = false
                };
                
                _helperlandContext.Users.Add(_user);
                _helperlandContext.SaveChanges();

                TempData["SuccessMessage"] = "Register Successfully. You can login after admin can approved your request.";

                return RedirectToAction("BecomeAPro");
            }

            return View("BecomeAPro", model);
        }

        //For Create new account,    check email is already present in database or noe
        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _helperlandContext.Users.FirstOrDefaultAsync(e => e.Email == email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email '{email}' is already in use. Please use another email.");
            }
        }

        //For forgotPassword, check 
        //[HttpPost]
        //[HttpGet]
        //public async Task<IActionResult> IsEmailValid(string email)
        //{
        //    var user = await _helperlandContext.Users.FirstOrDefaultAsync(e => e.Email == email);

        //    if (user == null)
        //    {
        //        return Json($"You are not register user. Please enter register email address.");
        //    }
        //    else
        //    {
        //        return Json(true);
        //    }
        //}

        [HttpPost]
        public IActionResult ForgotPassword(LoginAndForgotPasswordViewModel model)
        {
            ViewBag.navbar = "transparentNavbar";

            if (ModelState.IsValid)
            {
                _user = _helperlandContext.Users.Where(c => c.Email == model.ForgotPassword.Email).FirstOrDefault();

                if(_user != null)
                {
                    //Convert password to base64string
                    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(_user.Password);
                    var oldPassword = System.Convert.ToBase64String(plainTextBytes);

                    //create token
                    string inputToken = model.ForgotPassword.Email + "_$_" + DateTime.Now.ToString() + "_$_" + oldPassword;

                    //encrypt token
                    var protector = _dataProtectionProvider.CreateProtector(_Key);
                    string encryptToken = protector.Protect(inputToken);

                    EmailModel emailModel = new EmailModel
                    {
                        DisplayName = _user.FirstName + " " + _user.LastName,
                        To = model.ForgotPassword.Email,
                        Subject = "Helperland Reset Password Link.",
                        Body = "http://" + this.Request.Host.ToString() + "/Account/ResetPassword?token=" + encryptToken
                    };

                    MailHelper mailHelper = new MailHelper(_configuration, _hostingEnvironment);

                    mailHelper.SendResetPasswordLink(emailModel);
                }

                ViewBag.OpenModel = "ForgotPasswordLinkSend";
                return View("~/Views/home/index.cshtml");
            }

            ViewBag.OpenModel = "ForgotPassword";

            return View("~/Views/home/index.cshtml", model);
        }

        public IActionResult ResetPassword(string token)
        {
            if(token == null)
            {
                ViewBag.Messsage = "Password reset link is invalid.";
                return View();
            }
            else
            {
                checkResetPasswordToken(token);
            }

            return View();
        }

        private bool checkResetPasswordToken(string token)
        {
            string decrypt = "";
            try
            {
                var protector = _dataProtectionProvider.CreateProtector(_Key);
                decrypt = protector.Unprotect(token);
            }
            catch
            {
                ViewBag.Messsage = "Password reset link is invalid.";
                return false;
            }

            string[] resetPasswordToken = decrypt.Split("_$_");

            _user = _helperlandContext.Users.Where(c => c.Email == resetPasswordToken[0]).FirstOrDefault();

            DateTime tokenDate = Convert.ToDateTime(resetPasswordToken[1]).AddMinutes(30);
            DateTime currentDateTime = DateTime.Now;

            var base64EncodedBytes = System.Convert.FromBase64String(resetPasswordToken[2]);
            var oldPassword = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);


            if (tokenDate < currentDateTime || oldPassword != _user.Password)
            {
                ViewBag.Messsage = "Link is expired";
                return false;
            }

            return true;
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if(ModelState.IsValid)
            {
                if (!checkResetPasswordToken(model.Token))
                {
                    return View();
                }

                if(_user.Password == model.NewPassword)
                {
                    TempData["Message"] = "You used this password recently. Please choose a different one.";
                    return View(model);
                }

                _user.Password = model.NewPassword;
                _user.ModifiedBy = _user.UserId;
                _user.ModifiedDate = DateTime.Now;

                _helperlandContext.Users.Update(_user);
                _helperlandContext.SaveChanges();

                ViewBag.Messsage = "Success";

                return View();
            }
            return View(model);
        }
    }
}
