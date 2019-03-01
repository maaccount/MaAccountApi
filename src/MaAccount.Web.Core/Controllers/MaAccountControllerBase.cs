using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MaAccount.Controllers
{
    public abstract class MaAccountControllerBase: AbpController
    {
        protected MaAccountControllerBase()
        {
            LocalizationSourceName = MaAccountConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
