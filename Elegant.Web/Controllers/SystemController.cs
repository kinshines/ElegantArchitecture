using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult CookieConsent1()
        {
            return View();
        }
        public IActionResult CookieConsent2()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
        public IActionResult NotFound1()
        {
            return View();
        }
        public IActionResult NotFound2()
        {
            return View();
        }
        public IActionResult NotFound3()
        {
            return View();
        }
        public IActionResult Error1()
        {
            return View();
        }
        public IActionResult Error2()
        {
            return View();
        }
    }
}
