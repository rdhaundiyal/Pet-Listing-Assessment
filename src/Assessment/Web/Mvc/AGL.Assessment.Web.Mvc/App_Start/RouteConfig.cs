using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AGL.Assessment.Web.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Error",
              url: "Error/{errorId}",
              defaults: new { controller = "Error", action = "Index", errorId = "GenericError" }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{petType}",
                defaults: new { controller = "Home", action = "Pet", petType = "cat" }
            );
        }
    }
}
