using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using SchoolApp.Models; //for AnnouncementData
using SchoolApp.Services; //for Announcement and IAnnouncementRepository
using SchoolApp.UserControl;
using SchoolApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SchoolApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {

        private string _username;
        private string _password;
        private bool _loginBtnEnabled;
        readonly ILoginRepository loginRepository = new LoginService();
        readonly IAnnouncementRepository announcementRepository = new AnnouncementService();
        public string? Username { get
            { return this._username; } set {
          CheckUserNameAndPassword();
                this._username = value;
            
            } 
        }

        public bool LoginBtnEnabled
        {
            get
            { return this._loginBtnEnabled; }
            set
            {
                this._loginBtnEnabled = value;

            }
        }
        public string? Password {
            get
            { return this._password; }
            set
            {
                CheckUserNameAndPassword();
                this._password = value;

            }

        }

        private void CheckUserNameAndPassword()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
                this._loginBtnEnabled = true;

        }
        public ObservableCollection<AnnouncementData> Announcement { get; set; }

        public LoginPageViewModel()
        {
            Announcement = new ObservableCollection<AnnouncementData>();
        }

        [RelayCommand]
        public async Task Login()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepository.Login(Username, Password);

                if (Preferences.ContainsKey(nameof(App.UserInfo)))
                {
                    Preferences.Remove(nameof(App.UserInfo));
                }

                string userDetails = JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }

        private async Task LoadAnnouncements()
        {
            var announcements = await announcementRepository.GetAnnouncements();
            Announcement.Clear();
            foreach (var announcement in announcements)
            {
                Announcement.Add(announcement);
            }
        }
        //public class AnnouncementData
        //{
        //    public string Comment { get; set; }
        //    public string SentBy { get; set; }
        //    public string SetDate { get; set; }
        //    public string SetTime { get; set; }
        //}
    }

}

//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using Newtonsoft.Json;
//using SchoolApp.Models; // for AnnouncementData
//using SchoolApp.Services; // for Announcement and IAnnouncementRepository
//using SchoolApp.UserControl;
//using SchoolApp.Views;
//using System.Collections.ObjectModel;
//using System.Threading.Tasks;
////using Xamarin.Essentials; 

//namespace SchoolApp.ViewModels
//{
//    public partial class LoginPageViewModel : BaseViewModel
//    {
//        readonly ILoginRepository loginRepository = new LoginService();
//        readonly IAnnouncementRepository announcementRepository = new AnnouncementService();


//        public string? Username;


//        public string? Password;

//        public ObservableCollection<AnnouncementData> Announcement { get; set; }

//        public LoginPageViewModel()
//        {
//            Announcement = new ObservableCollection<AnnouncementData>();
//        }

//        [RelayCommand(CanExecute = nameof(IsLoginEnabled))]
//        public async Task Login()
//        {
//            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
//            {
//                UserInfo userInfo = await loginRepository.Login(Username, Password);

//                if (Preferences.ContainsKey(nameof(App.UserInfo)))
//                {
//                    Preferences.Remove(nameof(App.UserInfo));
//                }

//                string userDetails = JsonConvert.SerializeObject(userInfo);
//                Preferences.Set(nameof(App.UserInfo), userDetails);
//                App.UserInfo = userInfo;

//                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

//                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
//            }
//        }

//        private async Task LoadAnnouncements()
//        {
//            var announcements = await announcementRepository.GetAnnouncements();
//            Announcement.Clear();
//            foreach (var announcement in announcements)
//            {
//                Announcement.Add(announcement);
//            }
//        }

//        // Computed property to determine if the login button should be enabled
//        public bool IsLoginEnabled =>
//            !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
//    }
//}

