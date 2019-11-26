using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TEST.Configuration.Dto;

namespace TEST.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TESTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
