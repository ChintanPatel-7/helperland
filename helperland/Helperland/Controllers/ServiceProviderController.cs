using Helperland.Core;
using Helperland.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    [CookieHelper]
    [SessionHelper(userType: UserTypeEnum.ServiceProvider)]
    public class ServiceProviderController : Controller
    {
        public IActionResult UpcomingService()
        {
            return View();
        }

        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
