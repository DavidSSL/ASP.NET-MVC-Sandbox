// Taken from http://blog.ploeh.dk/2009/11/30/GlobalErrorHandlinginASP.NETMVC/
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC4_WebApplication_InternetApplication.Infrastructure
{
    public class ErrorHandlingControllerFactory:DefaultControllerFactory
    {
        public override IController CreateController(
            RequestContext requestContext,
            string controllerName)
        {
            var controller =
                base.CreateController(requestContext, controllerName);

            var c = controller as Controller;

            if (c != null)
            {
                c.ActionInvoker =
                    new ErrorHandlingActionInvoker(new HandleErrorAttribute());
            }

            return controller;
        }
    }
}