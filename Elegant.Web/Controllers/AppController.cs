using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Todo()
        {
            return View();
        }

        public IActionResult Todo2()
        {
            return View();
        }

        public IActionResult Ticket()
        {
            return View();
        }

        public IActionResult Inbox()
        {
            return View();
        }

        public IActionResult InboxMessage()
        {
            return PartialView();
        }

        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Config()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
