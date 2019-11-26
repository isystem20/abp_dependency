using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TEST.Roles.Dto;
using TEST.Users.Dto;

namespace TEST.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
