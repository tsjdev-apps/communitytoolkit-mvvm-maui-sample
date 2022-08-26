using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkitMVVMMauiSample.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    [NotifyCanExecuteChangedFor(nameof(GreetCommand))]
    private string _firstName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    [NotifyCanExecuteChangedFor(nameof(GreetCommand))]
    private string _lastName;

    public string FullName => $"{FirstName} {LastName}";

    [RelayCommand(AllowConcurrentExecutions = false, CanExecute = nameof(CanGreetUser))]
    private async Task GreetAsync()
    {
        IsLoading = true;

        await Application.Current.MainPage.DisplayAlert("Hello!", $"Hi, {FullName}!", "Ok");

        IsLoading = false;
    }

    private bool CanGreetUser
        => !string.IsNullOrWhiteSpace(FullName);
}
