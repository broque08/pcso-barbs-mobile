using CommunityToolkit.Mvvm.ComponentModel;
using pcso_barbs.ViewModel;

namespace pcso_barbs.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;
}