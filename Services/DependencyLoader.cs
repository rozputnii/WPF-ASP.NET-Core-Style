using Microsoft.Extensions.DependencyInjection;
using Services.Default;
using Common;

namespace Services
{
	public sealed class DependencyLoader : IDependencyLoader
	{
		public void Load(IServiceCollection services)
		{
			services.AddTransient<ISomeService, SomeService>();
		}
	}
}
