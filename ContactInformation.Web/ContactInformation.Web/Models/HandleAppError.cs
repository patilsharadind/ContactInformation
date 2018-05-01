using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactInformation.Web.Models
{
    /// <summary>
    /// Handle applicationn error at one place by inheriting HandleErrorAttribute
    /// </summary>
    public class HandleAppError : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var model = new HandleErrorInfo(filterContext.Exception, "Controller", "Action");

            //Log error - TODO: Using singletone pattern do error logging in text file and email.
            string errorMessage = ErrorLog.CreateErrorMessage(filterContext.Exception);
            ErrorLog.LogFileWrite(errorMessage);

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewData = new ViewDataDictionary(model)
            };
        }
    }
}