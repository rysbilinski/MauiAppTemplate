using MauiBasicTemplate.ViewModels;

namespace MauiBasicTemplate.Pages;

public partial class FetchDataPage : ContentPage
{
    private readonly FetchDataViewModel viewModel;

    public FetchDataPage(FetchDataViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = this.viewModel = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.viewModel.OnAppearing(this);
    }
}