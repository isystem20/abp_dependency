using Abp.Authorization;
using TEST.Authorization.Roles;
using TEST.Authorization.Users;

namespace TEST.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
