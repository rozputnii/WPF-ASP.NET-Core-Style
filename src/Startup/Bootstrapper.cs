using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Common.Configuration;
using Services;

namespace Startup
{
    internal static class Bootstrapper
	{
		public static IServiceProvider ConfigureServices()
		{
			var configuration = CreateConfiguration();
			IServiceCollection services = new ServiceCollection();

			services
				.AddOptions()
				.AddConfiguration(configuration);

			new DependencyLoader().Load(services);
			new ViewModels.DependencyLoader().Load(services);
			new Views.DependencyLoader().Load(services);

			services.AddConfiguration(configuration);

			return services.BuildServiceProvider();
		}

		private static IServiceCollection AddConfiguration(
			this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddSingleton(configuration);
			services.Configure<CommonSettings>(configuration);

			return services;
		}

		private static IConfiguration CreateConfiguration() =>
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();
    }
}
