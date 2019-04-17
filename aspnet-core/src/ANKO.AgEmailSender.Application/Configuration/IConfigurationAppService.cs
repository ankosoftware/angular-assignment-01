using System.Threading.Tasks;
using ANKO.AgEmailSender.Configuration.Dto;

namespace ANKO.AgEmailSender.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
