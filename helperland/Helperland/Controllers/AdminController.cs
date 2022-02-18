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
    [SessionHelper(userType: UserTypeEnum.Admin)]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManagement()
        {
            return View();
        }
    }
}
