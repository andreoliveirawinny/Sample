﻿using System.Web.Mvc;

namespace Sample.Areas.Backoffice
{
    public class BackofficeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Backoffice";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Backoffice_default",
                "Backoffice/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Sample.Areas.Backoffice.Controllers" }
            );
        }
    }
}