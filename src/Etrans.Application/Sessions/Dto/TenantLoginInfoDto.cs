using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Etrans.MultiTenancy;

namespace Etrans.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
