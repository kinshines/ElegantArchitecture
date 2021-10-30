using Elegant.Infrastructure.Services;
using Elegant.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NAutowired.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class HomeController : Controller
    {
        [Autowired]
        readonly ILogger<HomeController> logger;
        [Autowired]
        DashboardService dashboardService;

        public IActionResult Index()
        {
            var model = dashboardService.GetSummary();
            logger.LogInformation("get summary");
            return View(model);
        }
        public IActionResult Dashboard2()
        {
            var model = dashboardService.GetSummary();
            return View(model);
        }
        public IActionResult Dashboard3()
        {
            var model = dashboardService.GetSummary();
            return View(model);
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
