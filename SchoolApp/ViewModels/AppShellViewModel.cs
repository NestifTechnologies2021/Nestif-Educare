using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]

        async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserInfo)))
            {
                Preferences.Remove(nameof(App.UserInfo));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
