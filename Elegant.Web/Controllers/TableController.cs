using Elegant.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Basic()
        {
            return View();
        }
        public IActionResult Responsive()
        {
            return View();
        }
        public IActionResult Bootstrap()
        {
            return View();
        }
        public IActionResult DatatablesManaged()
        {
            return View();
        }
        public IActionResult DatatablesButton()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AjaxData()
        {
            var data = new AjaxDataModel()
            {
                Draw = 1,
                RecordsTotal = 178,
                RecordsFiltered = 178,
                Data = new List<List<object>>()
            };
            for(int i = 1; i < 178; i++)
            {
                var item = new List<object>();
                item.Add($"<label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\"><input name = \"id[]\" type=\"checkbox\" class=\"checkboxes\" value=\"{i}\"/><span></span></label>");
                item.Add(i);
                item.Add(DateTime.Now.ToLongDateString());
                item.Add("Jhon Doe");
                item.Add("Jhon Doe");
                item.Add("450.60$");
                item.Add(2 * i);
                item.Add("<span class=\"label label-sm label-info\">Closed</span>");
                item.Add("<a href=\"javascript:;\" class=\"btn btn-sm btn-outline grey-salsa\"><i class=\"fa fa-search\"></i> View</a>");
                data.Data.Add(item);
            }
            return Json(data);
        }

        public IActionResult DatatablesColreorder()
        {
            return View();
        }
        public IActionResult DatatablesRowreorder()
        {
            return View();
        }
        public IActionResult DatatablesScroller()
        {
            return View();
        }
        public IActionResult DatatablesFixedHeader()
        {
            return View();
        }
        public IActionResult DatatablesResponsive()
        {
            return View();
        }
        public IActionResult DatatablesEditable()
        {
            return View();
        }
        public IActionResult DatatablesAjax()
        {
            return View();
        }
    }
}
