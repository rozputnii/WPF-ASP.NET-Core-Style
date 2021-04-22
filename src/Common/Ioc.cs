using System;
using Microsoft.Extensions.DependencyInjection;

namespace Common
{
	public static class Ioc
	{
		private static readonly object LockObject;
		private static IServiceProvider _serviceProvider;

		static Ioc() => LockObject = new object();

        public static T Get<T>() => _serviceProvider.GetRequiredService<T>();

        public static void Init(IServiceProvider serviceProvider)
		{
			if (_serviceProvider != null)
			{
				return;
			}

			lock (LockObject)
			{
				if (_serviceProvider != null)
				{
					return;
				}

				_serviceProvider = serviceProvider;
			}
		}
	}
}
