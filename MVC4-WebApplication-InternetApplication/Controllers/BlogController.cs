﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_WebApplication_InternetApplication.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(int year, int month, int day)
        {
            return Content(string.Format("You've just hit BlogController.List with year: {0}, month: {1} and day: {2}", year, month, day));
        }

    }
}
