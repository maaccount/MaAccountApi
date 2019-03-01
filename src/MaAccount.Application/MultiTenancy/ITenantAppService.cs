using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MaAccount.MultiTenancy.Dto;

namespace MaAccount.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

