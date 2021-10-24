using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class ElementController : Controller
    {
        public IActionResult Step()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Ribbon()
        {
            return View();
        }
        public IActionResult Overlay()
        {
            return View();
        }
        public IActionResult UserCard()
        {
            return View();
        }
    }
}
