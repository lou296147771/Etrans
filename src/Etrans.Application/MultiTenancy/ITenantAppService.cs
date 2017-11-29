using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Etrans.MultiTenancy.Dto;

namespace Etrans.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
