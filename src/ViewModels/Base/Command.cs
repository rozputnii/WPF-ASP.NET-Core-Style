using System;
using System.Windows.Input;

namespace ViewModels.Base
{
	internal sealed class Command : ICommand
	{
		private readonly Action<object> execute;

		public Command(Action execute) : this(x => execute.Invoke())
		{
		}

		public Command(Action<object> execute) => this.execute = execute;

        public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => execute.Invoke(parameter);
    }
}
