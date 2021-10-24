using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Google()
        {
            return View();
        }
        public IActionResult Vector()
        {
            return View();
        }
    }
}
