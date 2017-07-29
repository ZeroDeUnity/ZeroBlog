using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ZeroBlog.Authorization;
using ZeroBlog.MultiTenancy;

namespace ZeroBlog.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ZeroBlogControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}