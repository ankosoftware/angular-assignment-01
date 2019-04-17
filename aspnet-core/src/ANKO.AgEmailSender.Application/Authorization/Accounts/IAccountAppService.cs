using System.Threading.Tasks;
using Abp.Application.Services;
using ANKO.AgEmailSender.Authorization.Accounts.Dto;

namespace ANKO.AgEmailSender.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
