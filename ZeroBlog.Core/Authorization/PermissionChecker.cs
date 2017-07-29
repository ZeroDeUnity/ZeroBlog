using Abp.Authorization;
using ZeroBlog.Authorization.Roles;
using ZeroBlog.MultiTenancy;
using ZeroBlog.Users;

namespace ZeroBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
