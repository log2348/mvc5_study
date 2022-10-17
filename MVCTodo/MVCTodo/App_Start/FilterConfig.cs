﻿using MVCTodo.FIlter;
using System.Web;
using System.Web.Mvc;

namespace MVCTodo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionFilter1());
        }
    }
}
