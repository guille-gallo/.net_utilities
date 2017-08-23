using System.Data.Entity.Migrations;

namespace AngularMVCTemplate.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AngularMVCTemplate.EntityFramework.AngularMVCTemplateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AngularMVCTemplate";
        }

        protected override void Seed(AngularMVCTemplate.EntityFramework.AngularMVCTemplateDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
