using CommunityToolkit.Mvvm.ComponentModel;

namespace CommunityToolkitMVVMMauiSample.ViewModels;

[INotifyPropertyChanged]
public partial class BaseViewModel
{
    [ObservableProperty]
    private bool _isLoading;
}
