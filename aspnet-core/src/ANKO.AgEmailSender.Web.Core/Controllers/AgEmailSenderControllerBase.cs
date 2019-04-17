using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ANKO.AgEmailSender.Controllers
{
    public abstract class AgEmailSenderControllerBase: AbpController
    {
        protected AgEmailSenderControllerBase()
        {
            LocalizationSourceName = AgEmailSenderConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
