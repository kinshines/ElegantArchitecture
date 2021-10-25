using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class PageLayoutController : Controller
    {
        public IActionResult Blank()
        {
            return View();
        }
        public IActionResult LanguageBar()
        {
            return View();
        }
        public IActionResult FixedFooter()
        {
            return View();
        }
        public IActionResult Boxed()
        {
            return View();
        }

        public IActionResult LanguageOption()
        {
            return PartialView();
        }
    }
}
