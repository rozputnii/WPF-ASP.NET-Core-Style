using System.Windows.Input;
using Microsoft.Extensions.Options;
using Services;
using Common.Configuration;
using ViewModels.Base;

namespace ViewModels.Default
{
    internal sealed class MainWindowModel : BaseViewModel, IMainWindowModel
	{
		private readonly ISomeService someService;
		private string name;

		public MainWindowModel(ISomeService someService,
			IOptions<CommonSettings> commonSettings)
		{
			this.someService = someService;
			Name = commonSettings.Value.DefaultName;

			Change = new Command(ChangeAction);
		}

		public string Name
		{
			get => name;
			set => SetProperty(out name, value);
		}

		public ICommand Change { get; }

		private void ChangeAction() => Name = someService.GetName();
    }
}
