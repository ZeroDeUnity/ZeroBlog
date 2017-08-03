using System.Data.Common;
using Abp.Zero.EntityFramework;
using ZeroBlog.Authorization.Roles;
using ZeroBlog.MultiTenancy;
using ZeroBlog.Users;
using System.Data.Entity;
using ZeroBlog.ZeroBlogSQL;

namespace ZeroBlog.EntityFramework
{
    public class ZeroBlogDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ZeroBlogDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ZeroBlogDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ZeroBlogDbContext since ABP automatically handles it.
         */
        public ZeroBlogDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ZeroBlogDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ZeroBlogDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public IDbSet<Zero_UserInfo> Zero_UserInfo { get;set;}

    }
}
