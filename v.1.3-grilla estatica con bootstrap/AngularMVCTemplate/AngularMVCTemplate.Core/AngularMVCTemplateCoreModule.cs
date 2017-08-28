using System.Reflection;
using Abp.Modules;

namespace AngularMVCTemplate
{
    public class AngularMVCTemplateCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
