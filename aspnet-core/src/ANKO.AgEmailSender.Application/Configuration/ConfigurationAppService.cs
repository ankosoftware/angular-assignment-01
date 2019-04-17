using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ANKO.AgEmailSender.Configuration.Dto;

namespace ANKO.AgEmailSender.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgEmailSenderAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
