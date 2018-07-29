using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UsedCarDealerWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Car", action = "List", id = UrlParameter.Optional }

            routes.MapRoute(null, "",
                new
                {
                    controller = "Car",
                    action = "List",
                    carBrand = (string)null,
                    page = 1
                }
            );

            routes.MapRoute(null, "Strona{page}",
                new { controller = "Car", action = "List", carBrand = (string)null },
                new { page = @"\d+" }
                );

            routes.MapRoute(null, "{carBrand}",
                new { controller = "Car", action = "List", page = 1 }
                );

            routes.MapRoute(null, "{carBrand}/Strona{page}",
                new { controller = "Car", action = "List" },
                new { page = @"\d+" }
                );


            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
