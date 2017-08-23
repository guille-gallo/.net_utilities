using System.Data.Common;
using Abp.EntityFramework;

namespace AngularMVCTemplate.EntityFramework
{
    public class AngularMVCTemplateDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AngularMVCTemplateDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AngularMVCTemplateDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AngularMVCTemplateDbContext since ABP automatically handles it.
         */
        public AngularMVCTemplateDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AngularMVCTemplateDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AngularMVCTemplateDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
