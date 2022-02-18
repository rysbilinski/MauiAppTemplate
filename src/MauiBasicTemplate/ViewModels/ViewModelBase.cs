using System.ComponentModel;

namespace MauiBasicTemplate.ViewModels;

public partial class ViewModelBase : ObservableObject, ILifecycleAware
{
    [ObservableProperty] private bool isBusy;
    [ObservableProperty] private string title;

    public virtual void OnAppearing(object view)
    {        
    }

    public virtual void OnDisappearing(object view)
    {        
    }
}

public interface ILifecycleAware
{
    void OnAppearing(object view);
    void OnDisappearing(object view);
}