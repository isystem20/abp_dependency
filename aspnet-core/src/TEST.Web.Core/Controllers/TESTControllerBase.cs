using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TEST.Controllers
{
    public abstract class TESTControllerBase: AbpController
    {
        protected TESTControllerBase()
        {
            LocalizationSourceName = TESTConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
