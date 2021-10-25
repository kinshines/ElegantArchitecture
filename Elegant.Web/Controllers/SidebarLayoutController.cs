using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class SidebarLayoutController : Controller
    {
        public IActionResult Hover()
        {
            return View();
        }
        public IActionResult Reversed()
        {
            return View();
        }
        public IActionResult Fixed()
        {
            return View();
        }
        public IActionResult Closed()
        {
            return View();
        }
    }
}
