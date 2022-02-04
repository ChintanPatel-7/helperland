using Helperland.Core;
using Helperland.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class ServiceProviderController : Controller
    {
        [SessionHelper(userType: UserTypeEnum.ServiceProvider)]
        public IActionResult UpcomingService()
        {
            return View();
        }
    }
}
