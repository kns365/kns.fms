using Abp.Application.Services;
using kns.fms.MultiTenancy.Dto;

namespace kns.fms.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

