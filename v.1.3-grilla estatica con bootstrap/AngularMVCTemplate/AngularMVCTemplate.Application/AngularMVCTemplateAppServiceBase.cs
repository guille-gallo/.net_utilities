using Abp.Application.Services;

namespace AngularMVCTemplate
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AngularMVCTemplateAppServiceBase : ApplicationService
    {
        protected AngularMVCTemplateAppServiceBase()
        {
            LocalizationSourceName = AngularMVCTemplateConsts.LocalizationSourceName;
        }
    }
}