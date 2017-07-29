using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ZeroBlog.EntityFramework.Repositories
{
    public abstract class ZeroBlogRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ZeroBlogDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ZeroBlogRepositoryBase(IDbContextProvider<ZeroBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ZeroBlogRepositoryBase<TEntity> : ZeroBlogRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ZeroBlogRepositoryBase(IDbContextProvider<ZeroBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
