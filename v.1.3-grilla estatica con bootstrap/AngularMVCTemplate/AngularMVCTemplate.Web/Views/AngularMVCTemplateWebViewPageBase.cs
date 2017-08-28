using Abp.Web.Mvc.Views;

namespace AngularMVCTemplate.Web.Views
{
    public abstract class AngularMVCTemplateWebViewPageBase : AngularMVCTemplateWebViewPageBase<dynamic>
    {

    }

    public abstract class AngularMVCTemplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularMVCTemplateWebViewPageBase()
        {
            LocalizationSourceName = AngularMVCTemplateConsts.LocalizationSourceName;
        }
    }
}