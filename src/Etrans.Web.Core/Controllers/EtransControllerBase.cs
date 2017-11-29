using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Etrans.Controllers
{
    public abstract class EtransControllerBase: AbpController
    {
        protected EtransControllerBase()
        {
            LocalizationSourceName = EtransConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
