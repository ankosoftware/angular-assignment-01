using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANKO.AgEmailSender.MultiTenancy.Dto;

namespace ANKO.AgEmailSender.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

