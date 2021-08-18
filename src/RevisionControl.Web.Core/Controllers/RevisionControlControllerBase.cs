using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RevisionControl.Controllers
{
    public abstract class RevisionControlControllerBase: AbpController
    {
        protected RevisionControlControllerBase()
        {
            LocalizationSourceName = RevisionControlConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
