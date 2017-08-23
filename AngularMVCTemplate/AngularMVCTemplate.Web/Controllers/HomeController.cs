using System.Web.Mvc;

namespace AngularMVCTemplate.Web.Controllers
{
    public class HomeController : AngularMVCTemplateControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}