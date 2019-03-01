using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MaAccount.Roles.Dto;
using MaAccount.Users.Dto;

namespace MaAccount.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
