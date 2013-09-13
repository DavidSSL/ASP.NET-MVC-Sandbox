using System.Web.Mvc;
using MVC4_WebApplication_InternetApplication.Infrastructure;

namespace MVC4_WebApplication_InternetApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LoggingExceptionFilter(new HandleErrorAttribute(), new NLogWriter()));
        }
    }
}