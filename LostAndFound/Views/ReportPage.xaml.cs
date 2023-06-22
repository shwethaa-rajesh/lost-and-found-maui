using LostAndFound.ViewModels;

namespace LostAndFound.Views;

public partial class ReportPage : ContentPage
{
	ReportPageViewModel instance;
	Button selectedButton;
	public ReportPage(ReportPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		vm.Navigation = Navigation;
		instance = vm;
    }
	
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		if(selectedButton!=null)
        {
            selectedButton.BorderWidth = 0;
            selectedButton.BorderColor = Colors.Transparent;

        }
        selectedButton = sender as Button;
		instance.ReportType = selectedButton.Text;
		selectedButton.BorderWidth = 2;
		selectedButton.BorderColor = Colors.Black;

    }
}
