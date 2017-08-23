using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AngularMVCTemplate.EntityFramework.Repositories
{
    public abstract class AngularMVCTemplateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AngularMVCTemplateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AngularMVCTemplateRepositoryBase(IDbContextProvider<AngularMVCTemplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AngularMVCTemplateRepositoryBase<TEntity> : AngularMVCTemplateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AngularMVCTemplateRepositoryBase(IDbContextProvider<AngularMVCTemplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
