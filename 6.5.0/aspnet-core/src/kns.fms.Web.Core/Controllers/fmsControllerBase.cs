using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace kns.fms.Controllers
{
    public abstract class fmsControllerBase: AbpController
    {
        protected fmsControllerBase()
        {
            LocalizationSourceName = fmsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
