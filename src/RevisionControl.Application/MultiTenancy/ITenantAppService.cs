using Abp.Application.Services;
using RevisionControl.MultiTenancy.Dto;

namespace RevisionControl.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

