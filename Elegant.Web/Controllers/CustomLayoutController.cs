using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class CustomLayoutController : Controller
    {
        public IActionResult DisabledMenu()
        {
            return View();
        }
        public IActionResult DisabledLink()
        {
            return PartialView();
        }
    }
}
