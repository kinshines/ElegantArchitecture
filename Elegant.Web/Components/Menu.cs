using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Components
{
    public class Menu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
