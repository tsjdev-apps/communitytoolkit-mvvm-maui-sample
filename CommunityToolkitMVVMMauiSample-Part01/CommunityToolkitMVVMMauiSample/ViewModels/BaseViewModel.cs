using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommunityToolkitMVVMMauiSample.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
    private bool _isLoading;
    public bool IsLoading
    {
        get => _isLoading;
        set { _isLoading = value; OnPropertyChanged(); }
    }


    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
