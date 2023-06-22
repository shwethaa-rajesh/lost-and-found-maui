using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LostAndFound.Views;

namespace LostAndFound.ViewModels
{
	public partial class MainPageViewModel:ObservableObject
	{
		[ObservableProperty]
		INavigation navigation;

		public MainPageViewModel()
		{
		}

		[RelayCommand]
		void onClickReport()
		{
			Navigation.PushAsync(new ReportPage(new ReportPageViewModel()));
		}
	}
}

