using CommunityToolkitMVVMMauiSample.ViewModels;
using CommunityToolkitMVVMMauiSample.Views;

namespace CommunityToolkitMVVMMauiSample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Views
        builder.Services.AddTransient<MainPage>();

        // ViewModels
        builder.Services.AddTransient<MainViewModel>();

        return builder.Build();
    }
}
