using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MaAccount.Configuration.Dto;

namespace MaAccount.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MaAccountAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
