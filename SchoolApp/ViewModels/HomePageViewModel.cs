using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using SchoolApp.Models;
using SchoolApp.Services;
using SchoolApp.Services.HomePageServices;
using SchoolApp.UserControl;
using SchoolApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolApp.ViewModels
{
    public partial class HomePageViewModel : ViewBase
    {
        //[ObservableProperty]
        //private string? _userName;
        readonly IHomeRepository HomeRepository = new HomeService();

        //[RelayCommand]
        //public async void Home()
        //{
        //    try
        //    {
        //        if (!string.IsNullOrWhiteSpace(Username))
        //        {
        //            UserInfo userInfo = await HomeRepository.Home(Username);

        //            if (Preferences.ContainsKey(nameof(App.UserInfo)))
        //            {
        //                Preferences.Remove(nameof(App.UserInfo));
        //            }

        //            string userDetails = JsonConvert.SerializeObject(userInfo);
        //            Preferences.Set(nameof(App.UserInfo), userDetails);
        //            App.UserInfo = userInfo;

        //            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

        //            // await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        //        }
        //    }
        //    catch (Exception ex) { }

        //}
    }
}

