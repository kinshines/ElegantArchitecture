using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElegantArchitecture.Web.Controllers
{
    public class UiFeatureController : Controller
    {
        public IActionResult GridSystem()
        {
            return View();
        }
    }
}