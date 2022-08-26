using System.Windows.Input;

namespace CommunityToolkitMVVMMauiSample.ViewModels;

public class MainViewModel : BaseViewModel
{
    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string FullName => $"{FirstName} {LastName}";

    private ICommand _greetCommand;
    public ICommand GreetCommand => _greetCommand ??= new Command(Greet);

    private async void Greet()
    {
        IsLoading = true;

        await Application.Current.MainPage.DisplayAlert("Hello!", $"Hi, {FullName}!", "Ok");

        IsLoading = false;
    }
}
