using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RevisionControl.Configuration.Dto;

namespace RevisionControl.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RevisionControlAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
