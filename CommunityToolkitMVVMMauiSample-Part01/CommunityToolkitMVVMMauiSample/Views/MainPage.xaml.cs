using CommunityToolkitMVVMMauiSample.ViewModels;

namespace CommunityToolkitMVVMMauiSample.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();

		BindingContext = mainViewModel;
	}
}