// Taken from http://blog.ploeh.dk/2009/11/30/GlobalErrorHandlinginASP.NETMVC/

using System;
using System.Web.Mvc;

namespace MVC4_WebApplication_InternetApplication.Infrastructure
{
    public class ErrorHandlingActionInvoker : ControllerActionInvoker
    {
        private readonly IExceptionFilter _filter;

        public ErrorHandlingActionInvoker(
            IExceptionFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("filter");
            }
            _filter = filter;
        }

        protected override FilterInfo GetFilters(
            ControllerContext controllerContext,
            ActionDescriptor actionDescriptor)
        {
            var filterInfo =
                base.GetFilters(controllerContext,
                actionDescriptor);
            
            filterInfo.ExceptionFilters.Add(_filter);

            return filterInfo;
        }
    }
}