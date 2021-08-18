using System.Threading.Tasks;
using RevisionControl.Configuration.Dto;

namespace RevisionControl.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
