using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Elegant.Web.Controllers
{
    public class UiFeatureController : Controller
    {
        public IActionResult GridSystem()
        {
            return View();
        }

        public IActionResult ColorLibrary()
        {
            return View();
        }

        public IActionResult SpinnerButton()
        {
            return View();
        }
    }
}