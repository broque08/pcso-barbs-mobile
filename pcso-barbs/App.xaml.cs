using pcso_barbs.View;

namespace pcso_barbs;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//Login");
    }
}