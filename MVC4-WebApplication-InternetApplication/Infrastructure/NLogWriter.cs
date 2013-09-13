using System;
using NLog;

namespace MVC4_WebApplication_InternetApplication.Infrastructure
{
    public class NLogWriter : ILogWriter
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public void WriteError(Exception exception)
        {
            _logger.Error("An exception occurred with the following message {0}\n and the following stacktrace: {1}", exception.Message, exception.StackTrace);
        }
    }
}