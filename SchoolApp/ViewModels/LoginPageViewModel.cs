using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using SchoolApp.Models;
using SchoolApp.Services;
using SchoolApp.UserControl;
using SchoolApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolApp.ViewModels
{
    public partial class LoginPageViewModel  : BaseViewModel
    {
      

        readonly ILoginRepository loginRepository = new LoginService();

        public string? Username { get; set; }
        public string? Password { get; set; }

        [RelayCommand]
        public async Task Login()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepository.Login(Username, Password);

                if(Preferences.ContainsKey(nameof(App.UserInfo)))
                {
                    Preferences.Remove(nameof(App.UserInfo));
                }

                string userDetails=JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

               await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
