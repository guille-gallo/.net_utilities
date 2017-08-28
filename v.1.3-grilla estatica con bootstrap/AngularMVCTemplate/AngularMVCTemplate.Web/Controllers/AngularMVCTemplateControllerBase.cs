using Abp.Web.Mvc.Controllers;

namespace AngularMVCTemplate.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AngularMVCTemplateControllerBase : AbpController
    {
        protected AngularMVCTemplateControllerBase()
        {
            LocalizationSourceName = AngularMVCTemplateConsts.LocalizationSourceName;
        }
    }
}