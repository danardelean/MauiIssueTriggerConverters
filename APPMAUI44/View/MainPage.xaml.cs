using System.Windows.Input;
using APPMAUI44.Core.ViewModel;

namespace APPMAUI44;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	
	}


}


