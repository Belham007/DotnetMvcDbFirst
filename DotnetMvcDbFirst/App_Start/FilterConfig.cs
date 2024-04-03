﻿using DotnetMvcDbFirst.Filters;
using System.Web;
using System.Web.Mvc;

namespace DotnetMvcDbFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
           // filters.Add(new CustomAuthenticationFilter()); not working
        }
    }
}
