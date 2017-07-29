using System.Web.Mvc;

namespace ZeroBlog.Web.Controllers
{
    public class AboutController : ZeroBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}