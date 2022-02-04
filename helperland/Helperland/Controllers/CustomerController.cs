using Helperland.Core;
using Helperland.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Controllers
{
    public class CustomerController : Controller
    {
        [SessionHelper(userType: UserTypeEnum.Customer)]
        public IActionResult ServiceHistory()
        {
            return View();
        }
    }
}
