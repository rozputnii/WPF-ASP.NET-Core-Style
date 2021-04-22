using Microsoft.Extensions.DependencyInjection;
using Common;
using ViewModels.Default;

namespace ViewModels
{
	public sealed class DependencyLoader : IDependencyLoader
	{
		public void Load(IServiceCollection services) => services.AddTransient<IMainWindowModel, MainWindowModel>();
    }
}
