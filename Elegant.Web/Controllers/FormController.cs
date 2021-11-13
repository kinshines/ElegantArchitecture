using Elegant.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using NAutowired.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Elegant.Web.Controllers
{
    public class FormController : Controller
    {
        readonly IWebHostEnvironment host;
        FilesHelper filesHelper;

        public FormController(IWebHostEnvironment host)
        {
            string urlBase = "/demo/somefiles/";
            string deleteURL = "/Form/DeleteFile/?file=";
            string deleteType = "POST";
            string storageRoot = Path.Combine(host.WebRootPath, "demo/somefiles");
            filesHelper = new FilesHelper(deleteURL, deleteType, storageRoot, urlBase);
            this.host = host;
        }

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

        [HttpPost]
        public IActionResult CropDemo(int x,int y,int w,int h)
        {
            var root = host.WebRootPath;
            var filename = Path.Combine(root, "global/plugins/jcrop/demos/demo_files/image5.jpg");
            using var b = Image.FromFile(filename);
            using var nb = new Bitmap(w, h);
            using Graphics g = Graphics.FromImage(nb);
            g.DrawImage(b, -x, -y);
            using var thumb = nb.GetThumbnailImage(150, 150, null, System.IntPtr.Zero);
            using var stream = new MemoryStream();
            thumb.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return new FileContentResult(stream.ToArray(), "image/png");
        }
        public IActionResult FileUpload()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Upload(IEnumerable<string> names)
        {
            var files = filesHelper.GetFileList();
            return Json(files);
        }

        [HttpPost]
        public ActionResult DeleteFile(string file)
        {
            filesHelper.DeleteFile(file);
            return Json("OK");
        }

        [HttpPost]
        public IActionResult Upload()
        {
            var resultList = new List<ViewDataUploadFilesResult>();

            filesHelper.UploadAndShowResults(Request, resultList);
            JsonFiles files = new JsonFiles(resultList);

            bool isEmpty = !resultList.Any();
            if (isEmpty)
            {
                return Json("Error ");
            }
            else
            {
                return Json(files);
            }
        }

        public IActionResult Dropzone()
        {
            return View();
        }
    }
}
