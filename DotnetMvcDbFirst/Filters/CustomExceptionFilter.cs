﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotnetMvcDbFirst.Filters
{
    public class CustomExceptionFilter : FilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is NullReferenceException)
            {
                filterContext.Result = new RedirectResult("customErrorPage.html");
                filterContext.ExceptionHandled = true;
            }
            //ExceptionLogger logger = new ExceptionLogger()
            //{
            //    ExceptionMessage = filterContext.Exception.Message,
            //    ExceptionStackTrack = filterContext.Exception.StackTrace,
            //    ControllerName = filterContext.RouteData.Values["controller"].ToString(),
            //    ActionName = filterContext.RouteData.Values["action"].ToString(),
            //    ExceptionLogTime = DateTime.Now
            //};
            //EmployeeContext dbContext = new EmployeeContext();
            //dbContext.ExceptionLoggers.Add(logger);
            //dbContext.SaveChanges();

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
    }
}