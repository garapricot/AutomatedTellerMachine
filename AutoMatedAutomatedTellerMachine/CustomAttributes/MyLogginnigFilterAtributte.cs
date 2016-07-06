using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Logging;

namespace AutoMatedAutomatedTellerMachine.CustomAttributes
{
    public class MyLogginnigFilterAtributte:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            base.OnActionExecuted(filterContext);
        }

        
    }
}