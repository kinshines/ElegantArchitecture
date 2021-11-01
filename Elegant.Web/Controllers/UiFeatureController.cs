using Elegant.Core.Dtos;
using Elegant.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using NAutowired.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class UiFeatureController : Controller
    {
        [Autowired]
        TreeService treeService;
        public IActionResult MetronicGrid()
        {
            return View();
        }

        public IActionResult ColorLibrary()
        {
            return View();
        }

        public IActionResult GeneralComponent()
        {
            return View();
        }

        public IActionResult Button()
        {
            return View();
        }

        public IActionResult SpinnerButton()
        {
            return View();
        }

        public IActionResult SocialIcons()
        {
            return View();
        }

        public IActionResult Typography()
        {
            return View();
        }

        public IActionResult Confirmations()
        {
            return View();
        }

        public IActionResult SweetAlert()
        {
            return View();
        }

        public IActionResult FontIcon()
        {
            return View();
        }

        public IActionResult TabAccordion()
        {
            return View();
        }

        public IActionResult Timeline()
        {
            return View();
        }

        public IActionResult Timeline2()
        {
            return View();
        }

        public IActionResult HorizontalTimeline()
        {
            return View();
        }

        public IActionResult Tree()
        {
            return View();
        }

        public IActionResult TreeAjaxData(string parent)
        {
            var list = treeService.AjaxData(parent);
            return Json(list);
        }

        public IActionResult Progress1()
        {
            return View();
        }

        public IActionResult Progress2()
        {
            return View();
        }

        public IActionResult BlockUI()
        {
            return View();
        }

        public IActionResult Growl()
        {
            return View();
        }

        public IActionResult Notific8()
        {
            return View();
        }

        public IActionResult Toastr()
        {
            return View();
        }
        public IActionResult Bootbox()
        {
            return View();
        }
        public IActionResult Alert()
        {
            return View();
        }
        public IActionResult SessionTimeout()
        {
            return View();
        }
        public IActionResult IdleTimeout()
        {
            return View();
        }

        public IActionResult Modal()
        {
            return View();
        }

        public IActionResult ExtendModal()
        {
            return View();
        }
        public IActionResult Tile()
        {
            return View();
        }
        public IActionResult DatePaginator()
        {
            return View();
        }

        public IActionResult NestableList()
        {
            return View();
        }
    }
}
