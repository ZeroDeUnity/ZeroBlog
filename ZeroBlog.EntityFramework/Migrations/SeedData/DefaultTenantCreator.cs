using System.Linq;
using ZeroBlog.EntityFramework;
using ZeroBlog.MultiTenancy;

namespace ZeroBlog.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ZeroBlogDbContext _context;

        public DefaultTenantCreator(ZeroBlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
