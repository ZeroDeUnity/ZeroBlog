using System.Threading.Tasks;
using Abp.Application.Services;
using ZeroBlog.Roles.Dto;

namespace ZeroBlog.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
