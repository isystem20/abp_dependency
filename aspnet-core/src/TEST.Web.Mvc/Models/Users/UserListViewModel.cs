using System.Collections.Generic;
using TEST.Roles.Dto;
using TEST.Users.Dto;

namespace TEST.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
