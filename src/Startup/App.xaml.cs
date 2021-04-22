using System.Windows;
using Common;
using Views;

namespace Startup
{
	public partial class App : Application
	{
		public App()
		{
			var serviceProvider = Bootstrapper.ConfigureServices();
			Ioc.Init(serviceProvider);
        }
        
		private void OnStartup(
			object sender,
			StartupEventArgs e)
		{
            base.MainWindow = Ioc.Get<MainWindow>();;
            base.MainWindow?.Show();
		}
	}
}
