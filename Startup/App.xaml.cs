using System;
using System.Windows;
using Common;
using Views;

namespace Startup
{
	public partial class App : Application
	{
		public App()
		{
			IServiceProvider serviceProvider = Bootstrapper.ConfigureServices();
			Ioc.Init(serviceProvider);
		}

		private void OnStartup(
			object sender,
			StartupEventArgs e)
		{
			var mainWindow = Ioc.Get<MainWindow>();
			mainWindow.Show();
		}
	}
}
