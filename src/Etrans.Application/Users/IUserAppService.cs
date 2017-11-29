using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Etrans.Roles.Dto;
using Etrans.Users.Dto;

namespace Etrans.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
