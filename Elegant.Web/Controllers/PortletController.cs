using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class PortletController : Controller
    {
        public IActionResult Boxed()
        {
            return View();
        }
    }
}
