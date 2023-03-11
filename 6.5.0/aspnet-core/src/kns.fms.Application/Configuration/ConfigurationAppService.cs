using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using kns.fms.Configuration.Dto;

namespace kns.fms.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : fmsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
