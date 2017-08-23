using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace AngularMVCTemplate
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AngularMVCTemplateApplicationModule))]
    public class AngularMVCTemplateWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AngularMVCTemplateApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
