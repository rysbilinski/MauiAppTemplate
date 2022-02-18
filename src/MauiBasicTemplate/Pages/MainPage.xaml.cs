using MauiBasicTemplate.ViewModels;

namespace MauiBasicTemplate.Pages;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel viewModel;

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = this.viewModel = viewModel;
    }
}