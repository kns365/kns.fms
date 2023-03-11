using Abp.Authorization;
using kns.fms.Authorization.Roles;
using kns.fms.Authorization.Users;

namespace kns.fms.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
