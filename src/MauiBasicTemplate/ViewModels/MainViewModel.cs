namespace MauiBasicTemplate.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] 
    private int counter = 0;

    [ICommand]
    private void IncrementCounter()
    {
        Counter++;
        this.Title = $"Main {Counter}";
    }

    public MainViewModel()
    {
        this.Title = "Main";
    }
}
