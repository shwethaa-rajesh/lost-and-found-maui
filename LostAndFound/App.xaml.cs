using LostAndFound.Views;

namespace LostAndFound;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage(new ViewModels.MainPageViewModel()));
	}
}

