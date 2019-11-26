using System.Threading.Tasks;
using Abp.Application.Services;
using TEST.Authorization.Accounts.Dto;

namespace TEST.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
