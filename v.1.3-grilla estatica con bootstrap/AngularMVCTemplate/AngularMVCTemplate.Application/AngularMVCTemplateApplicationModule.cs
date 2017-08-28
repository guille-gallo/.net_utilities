using System.Reflection;
using Abp.Modules;

namespace AngularMVCTemplate
{
    [DependsOn(typeof(AngularMVCTemplateCoreModule))]
    public class AngularMVCTemplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
