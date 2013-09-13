using System;

namespace MVC4_WebApplication_InternetApplication.Infrastructure
{
    public interface ILogWriter
    {
        void WriteError(Exception exception);
    }
}