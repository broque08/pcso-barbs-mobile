using CommunityToolkit.Mvvm.Input;

namespace pcso_barbs.ViewModel;

public partial class ProfileViewModel : BaseViewModel
{
    [ICommand]
    public void GoToLogin()
    {
        Shell.Current.GoToAsync("//Login");
    }
}