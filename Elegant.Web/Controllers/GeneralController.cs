using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Portfolio1()
        {
            return View();
        }
        public IActionResult LoadMore()
        {
            return PartialView();
        }
        public IActionResult LoadMore2()
        {
            return PartialView();
        }
        public IActionResult Portfolio2()
        {
            return View();
        }
        public IActionResult Portfolio3()
        {
            return View();
        }
        public IActionResult Portfolio4()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Search2()
        {
            return View();
        }
        public IActionResult Search3()
        {
            return View();
        }
        public IActionResult Search4()
        {
            return View();
        }
        public IActionResult Search5()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogPost()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Invoice2()
        {
            return View();
        }
    }
}
