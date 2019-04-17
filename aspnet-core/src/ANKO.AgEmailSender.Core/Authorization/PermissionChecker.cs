using Abp.Authorization;
using ANKO.AgEmailSender.Authorization.Roles;
using ANKO.AgEmailSender.Authorization.Users;

namespace ANKO.AgEmailSender.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
