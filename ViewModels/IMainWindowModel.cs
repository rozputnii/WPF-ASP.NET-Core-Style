using System.Windows.Input;

namespace ViewModels
{
	public interface IMainWindowModel : IViewModel
	{
		string Name { get; set; }

		ICommand Change { get; }
	}
}
