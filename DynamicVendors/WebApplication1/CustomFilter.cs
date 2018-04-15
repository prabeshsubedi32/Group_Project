using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class CustomExceptionFilter : FilterAttribute,
    IExceptionFilter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void OnException(ExceptionContext filterContext)
        {
            //if (!filterContext.ExceptionHandled && filterContext.Exception is NullReferenceException)
            //{
                filterContext.Result = new RedirectResult("Error.html");
                filterContext.ExceptionHandled = true;
                 logger.Error(filterContext.Exception);
           // }
        }
    }
}