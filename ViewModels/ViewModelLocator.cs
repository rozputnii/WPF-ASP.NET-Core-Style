using Common;

namespace ViewModels
{
	public sealed class ViewModelLocator
	{
		public IMainWindowModel MainWindowModel => Ioc.Get<IMainWindowModel>();
	}
}
