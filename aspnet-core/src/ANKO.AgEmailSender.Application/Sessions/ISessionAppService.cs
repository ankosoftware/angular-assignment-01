using System.Threading.Tasks;
using Abp.Application.Services;
using ANKO.AgEmailSender.Sessions.Dto;

namespace ANKO.AgEmailSender.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
