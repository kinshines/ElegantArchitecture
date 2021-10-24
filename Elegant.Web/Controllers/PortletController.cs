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
        public IActionResult Light()
        {
            return View();
        }
        public IActionResult Solid()
        {
            return View();
        }
        public IActionResult Ajax()
        {
            return View();
        }
        public IActionResult Draggable()
        {
            return View();
        }
        public IActionResult AjaxContent1()
        {
            return PartialView();
        }
        public IActionResult AjaxContent2()
        {
            return PartialView();
        }
        public IActionResult AjaxContent3()
        {
            return PartialView();
        }
    }
}
