using pcso_barbs.ViewModel;

namespace pcso_barbs.View;

public partial class ProfilePage : ContentPage
{

    public ProfilePage(ProfileViewModel profileViewModel)
    {
        InitializeComponent();
        BindingContext = profileViewModel;
    }
}