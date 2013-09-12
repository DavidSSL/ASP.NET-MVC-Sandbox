using System;
using System.Diagnostics;
using System.Web.Mvc;
using MVC4_WebApplication_InternetApplication.Models;

namespace MVC4_WebApplication_InternetApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            
            HomeModels.ThrowException();
           

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
