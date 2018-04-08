using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AGL.Assessment.Domain.Exceptions;
using AGL.Assessment.Web.Mvc.App_Start;

namespace AGL.Assessment.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IocContainer.Initialize();
        }

        protected void Application_Error()
        {
            var errorId = "GenericError";
            var ex = Server.GetLastError();
            Server.ClearError();
            if (ex.GetType() == typeof (AssessmentException)) errorId = ((AssessmentException) ex).ErrorId;
            Response.Redirect(string.Format("/Error/{0}",errorId));
        }
    }
}
