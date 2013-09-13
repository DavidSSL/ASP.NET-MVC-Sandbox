using System;
using System.Web.Mvc;

namespace MVC4_WebApplication_InternetApplication.Infrastructure
{
    public class LoggingExceptionFilter : IExceptionFilter
    {
        private readonly IExceptionFilter _filter;

        private readonly ILogWriter _logWriter;

        public LoggingExceptionFilter(IExceptionFilter filter,
            ILogWriter logWriter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("filter");
            }

            if (logWriter == null)
            {
                throw new ArgumentNullException("logWriter");
            }

            _filter = filter;
            _logWriter = logWriter;
        }
        
        public void OnException(ExceptionContext filterContext)
        {
            _logWriter.WriteError(filterContext.Exception);
            _filter.OnException(filterContext);
        }
    }
}