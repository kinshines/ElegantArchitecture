using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Elegant.Web.Models;
using Elegant.Infrastructure.Services;

namespace Elegant.Web.Controllers
{
    public class HomeController : Controller
    {
        DashboardService _dashboardService;
        public HomeController(DashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        public IActionResult Index()
        {
            var model = _dashboardService.GetSummary();
            return View(model);
        }
        public IActionResult Dashboard2()
        {
            var model = _dashboardService.GetSummary();
            return View(model);
        }
        public IActionResult Dashboard3()
        {
            var model = _dashboardService.GetSummary();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
