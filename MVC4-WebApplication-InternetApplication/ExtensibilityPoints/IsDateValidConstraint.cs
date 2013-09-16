using System;
using System.Globalization;
using System.Web;
using System.Web.Routing;

namespace MVC4_WebApplication_InternetApplication.ExtensibilityPoints
{
    public class IsDateValidConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values,
                          RouteDirection routeDirection)
        {
            if (routeDirection == RouteDirection.IncomingRequest)
            {
                DateTime date;

                return DateTime.TryParse(String.Format("{0}/{1}/{2}"
                    , values["year"], values["month"], values["day"])
                    , CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            }
            return true;
        }
    }
}