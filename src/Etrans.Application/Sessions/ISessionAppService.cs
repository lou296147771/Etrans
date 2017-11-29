using System.Threading.Tasks;
using Abp.Application.Services;
using Etrans.Sessions.Dto;

namespace Etrans.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
