﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class LanguageController : Controller
    {
        //public ActionResult Index(string language)
        //{
        //    if (!string.IsNullOrEmpty(language))
        //    {
        //        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
        //        Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        //    }
        //    HttpCookie cookie = new HttpCookie("Language");
        //    cookie.Value = language;
        //    Response.Cookies.Add(cookie);

        //    return View();
        //}
    }
}