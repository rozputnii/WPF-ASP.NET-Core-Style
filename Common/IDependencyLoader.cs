using Microsoft.Extensions.DependencyInjection;

namespace Common
{
	public interface IDependencyLoader
	{
		void Load(IServiceCollection services);
	}
}
