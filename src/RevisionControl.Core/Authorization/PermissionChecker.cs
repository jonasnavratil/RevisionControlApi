using Abp.Authorization;
using RevisionControl.Authorization.Roles;
using RevisionControl.Authorization.Users;

namespace RevisionControl.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
