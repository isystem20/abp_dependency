using System.Threading.Tasks;
using TEST.Configuration.Dto;

namespace TEST.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
