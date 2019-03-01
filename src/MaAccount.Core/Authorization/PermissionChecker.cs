using Abp.Authorization;
using MaAccount.Authorization.Roles;
using MaAccount.Authorization.Users;

namespace MaAccount.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
