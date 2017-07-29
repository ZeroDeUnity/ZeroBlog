using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZeroBlog.Roles.Dto
{
    public class UpdateRolePermissionsInput
    {
        [Range(1, int.MaxValue)]
        public int RoleId { get; set; }

        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}