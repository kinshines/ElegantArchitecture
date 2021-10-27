using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult Profile2()
        {
            return View();
        }
    }
}
