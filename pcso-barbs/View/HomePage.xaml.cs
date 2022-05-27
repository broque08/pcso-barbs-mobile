using pcso_barbs.ViewModel;

namespace pcso_barbs.View;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }
}