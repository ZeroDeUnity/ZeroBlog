using ZeroBlog.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ZeroBlog.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ZeroBlogDbContext _context;

        public InitialHostDbBuilder(ZeroBlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
