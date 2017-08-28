using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AngularMVCTemplate.EntityFramework;

namespace AngularMVCTemplate
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AngularMVCTemplateCoreModule))]
    public class AngularMVCTemplateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AngularMVCTemplateDbContext>(null);
        }
    }
}
