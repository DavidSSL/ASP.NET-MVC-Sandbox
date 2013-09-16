using System.Web.Mvc;
using System.Web.Routing;
using MVC4_WebApplication_InternetApplication.ExtensibilityPoints;

namespace MVC4_WebApplication_InternetApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            string[] allowedMethods = { "GET" };

            routes.MapRoute("BlogArchive",
                "{year}/{month}/{day}",
                new { controller = "Blog", action = "List", month = "1", day = "1" },
                new
                {
                    year = @"\d{2}|\d{4}"
                    , month = @"\d{1,2}"
                    , day = @"\d{1,2}"
                    , dateIsValid = new IsDateValidConstraint()
                    ,
                    method = new HttpMethodConstraint(allowedMethods)
                }
                );

            routes.MapRoute("Post",
                "{title}",
                new { controller = "Blog", action = "Post" }
                );

            routes.MapRoute("Tags",
                "tags/{tag}",
                new { controller = "Blog", action = "Tags" }
            );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}