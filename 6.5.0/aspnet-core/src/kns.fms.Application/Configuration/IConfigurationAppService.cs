using System.Threading.Tasks;
using kns.fms.Configuration.Dto;

namespace kns.fms.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
