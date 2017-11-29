using System.Threading.Tasks;
using Etrans.Configuration.Dto;

namespace Etrans.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
