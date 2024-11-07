using Maxi.ViewModel;

namespace Maxi;

public partial class MainPage : ContentPage
{

	public MainPage(StoresViewModel viewModel) 
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

