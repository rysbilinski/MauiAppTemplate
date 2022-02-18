using MauiBasicTemplate.Models;
using MauiBasicTemplate.Services;
using System.Collections.ObjectModel;

namespace MauiBasicTemplate.ViewModels;

public partial class FetchDataViewModel : ViewModelBase
{

    [ObservableProperty] 
    private ObservableCollection<DataModel> data = new();

    private readonly IDataService dataService;

    public FetchDataViewModel(IDataService dataService)
    {
        this.dataService = dataService;
    }

    public override async void OnAppearing(object view)
    {
        base.OnAppearing(view);

        await RefreshData();
    }

    [ICommand]
    private async Task RefreshData()
    {
        try
        {
            IsBusy = true;
            this.Data = new();
            var data = await this.dataService.FetchData();
            this.Data = new ObservableCollection<DataModel>(data);
        }
        catch(Exception ex)
        {

        }
        finally
        {
            IsBusy = false;
        }
    }
}
