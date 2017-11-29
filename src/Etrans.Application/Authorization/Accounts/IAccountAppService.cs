using System.Threading.Tasks;
using Abp.Application.Services;
using Etrans.Authorization.Accounts.Dto;

namespace Etrans.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
