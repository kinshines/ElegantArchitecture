using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Control()
        {
            return View();
        }
        public IActionResult MaterialControl()
        {
            return View();
        }
        public IActionResult Validation()
        {
            return View();
        }
        public IActionResult MaterialValidationState()
        {
            return View();
        }
        public IActionResult MaterialValidation()
        {
            return View();
        }
        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Repeater()
        {
            return View();
        }
        public IActionResult InputMask()
        {
            return View();
        }
        public IActionResult Xeditable()
        {
            return View();
        }
        public IActionResult Wizard()
        {
            return View();
        }
        public IActionResult ICheck()
        {
            return View();
        }
        public IActionResult ImageCrop()
        {
            return View();
        }

        public IActionResult CropDemo(int x,int y,int w,int h)
        {
            //todo crop image as response
            return Ok();
        }
        public IActionResult FileUpload()
        {
            return View();
        }
        public IActionResult Dropzone()
        {
            return View();
        }
    }
}
