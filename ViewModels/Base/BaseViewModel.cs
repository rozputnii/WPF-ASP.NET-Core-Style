using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModels.Base
{
	internal class BaseViewModel : IViewModel, INotifyPropertyChanged
	{
		protected BaseViewModel()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SetProperty<T>(
			out T property,
			T value,
			[CallerMemberName] string propertyName = null)
		{
			property = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
