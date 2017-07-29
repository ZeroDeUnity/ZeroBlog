using Abp.Web.Mvc.Views;

namespace ZeroBlog.Web.Views
{
    public abstract class ZeroBlogWebViewPageBase : ZeroBlogWebViewPageBase<dynamic>
    {

    }

    public abstract class ZeroBlogWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ZeroBlogWebViewPageBase()
        {
            LocalizationSourceName = ZeroBlogConsts.LocalizationSourceName;
        }
    }
}