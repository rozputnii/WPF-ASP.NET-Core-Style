using Microsoft.Extensions.DependencyInjection;
using Common;

namespace Views
{
	public sealed class DependencyLoader : IDependencyLoader
	{
		public void Load(IServiceCollection services) => services.AddSingleton<MainWindow>();
    }
}
