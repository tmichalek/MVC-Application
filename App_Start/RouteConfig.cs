using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Zgloszenie_WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Zgloszenie",
            //    url: "{nazwa}",
            //    new { controller = "Home", action = "Zgloszenie" }
            //    );

            routes.MapRoute(
                name: "Przeglad",
                url: "Przeglad",
                new { controller = "Home", action = "Przeglad" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
