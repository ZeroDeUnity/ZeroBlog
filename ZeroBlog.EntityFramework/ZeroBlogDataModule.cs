using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ZeroBlog.EntityFramework;

namespace ZeroBlog
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ZeroBlogCoreModule))]
    public class ZeroBlogDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ZeroBlogDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
