using Abp.Authorization;
using Etrans.Authorization.Roles;
using Etrans.Authorization.Users;

namespace Etrans.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
