using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ZeroBlog.EntityFramework;

namespace ZeroBlog.Migrator
{
    [DependsOn(typeof(ZeroBlogDataModule))]
    public class ZeroBlogMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ZeroBlogDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}