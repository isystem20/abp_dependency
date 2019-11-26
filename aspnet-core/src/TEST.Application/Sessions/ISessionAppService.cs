using System.Threading.Tasks;
using Abp.Application.Services;
using TEST.Sessions.Dto;

namespace TEST.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
