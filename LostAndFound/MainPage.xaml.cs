using LostAndFound.ViewModels;

namespace LostAndFound;

public partial class MainPage : ContentPage
{


	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		vm.Navigation = Navigation;
	}


}


