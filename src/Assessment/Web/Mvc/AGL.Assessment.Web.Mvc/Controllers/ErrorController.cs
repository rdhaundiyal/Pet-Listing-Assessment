using System.Web.Mvc;
using AGL.Components.Helpers;

namespace AGL.Assessment.Web.Mvc.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/
        public ActionResult Index(string errorId="")
        {
            object message = string.Empty;
            if(!string.IsNullOrEmpty(errorId))
            message = ConfigHelper.GetValue<string>(errorId);
            return View(message );
        }
	}
}