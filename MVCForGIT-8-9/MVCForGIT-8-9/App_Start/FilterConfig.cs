﻿using System.Web;
using System.Web.Mvc;

namespace MVCForGIT_8_9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
