using System;
using MVC4_WebApplication_InternetApplication.Classes;

namespace MVC4_WebApplication_InternetApplication.Models
{
    public class HomeModels
    {
         public static void ThrowException()
         {
             throw new Exception("HomeModels exception");
         }

        public static void CallGrandChild()
        {
            GrandChild.ThrowException();
        }
    }
}