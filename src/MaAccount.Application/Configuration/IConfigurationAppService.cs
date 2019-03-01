using System.Threading.Tasks;
using MaAccount.Configuration.Dto;

namespace MaAccount.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
