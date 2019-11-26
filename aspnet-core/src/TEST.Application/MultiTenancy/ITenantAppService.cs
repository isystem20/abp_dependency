using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TEST.MultiTenancy.Dto;

namespace TEST.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

