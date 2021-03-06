using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Markup;
using pcso_barbs.View;
using pcso_barbs.ViewModel;

namespace pcso_barbs;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()

        .UseMauiCommunityToolkit()
        .UseMauiCommunityToolkitMarkup()
        .UseMauiCommunityToolkitCore()

        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<LoginPage>();

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomePage>();

        builder.Services.AddSingleton<ProfileViewModel>();
        builder.Services.AddSingleton<ProfilePage>();

        return builder.Build();
    }
}