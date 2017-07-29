using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ZeroBlog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ZeroBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}