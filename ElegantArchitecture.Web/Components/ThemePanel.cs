﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantArchitecture.Web.Components
{
    public class ThemePanel : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}