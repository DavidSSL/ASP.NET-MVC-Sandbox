using System.Web.Mvc;

namespace MVC4_WebApplication_InternetApplication.Controllers
{
    public class HttpErrorController : Controller
    {
        public ActionResult NotFound404()
        {
            return View();
        }
    }
}
