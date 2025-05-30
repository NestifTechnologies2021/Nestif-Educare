namespace SchoolApp.ChildPages;
using Newtonsoft;
using Newtonsoft.Json;
using SchoolApp.Models;
using SchoolApp.ViewModels;
using SchoolApp.Views;
using System.Collections;
using System.Threading.Tasks;
using System.Net.Http;

public partial class Announcement : ContentPage
{
    //public Announcement(object loginPageViewModel)
    //{
    //    InitializeComponent();
    //    BindingContext = new LoginPageViewModel();
    //    LoadAnnouncements();
    //}

    public Announcement(LoginPageViewModel loginPageViewModel)
    {
        loginPageViewModel.Username = "Announcement " + loginPageViewModel.Username;
        InitializeComponent();
        this.loginpageviewmodel = loginPageViewModel;
        LoadAnnouncements();
        this.BindingContext = this.loginpageviewmodel; ;
        
    }

    public LoginPageViewModel loginpageviewmodel { get; private set; }

    //change it to configurable file from hardcoded file by uploading the json file to github and calling using async
    private void LoadAnnouncements()
    {

        // var jsonFilePath = "D:\\Nestif\\NestifEducare\\Nestif-Educare\\SchoolApp\\ChildPages\\Announcement.json";

       var jsondata= @"
    [
      {
        ""Comment"": ""School is open"",
        ""SentBy"": ""Vice-Principal"",
        ""SetDate"": ""04-05-2025"",
        ""SetTime"": ""08:33:47""
      },
      {
        ""Comment"": ""School is closed"",
        ""SentBy"": ""Principal"",
        ""SetDate"": ""05-05-2025"",
        ""SetTime"": ""09:13:07""
      },
      {
        ""Comment"": ""Holiday Homework compulsory"",
        ""SentBy"": ""Teacher"",
        ""SetDate"": ""06-05-2025"",
        ""SetTime"": ""18:56:25""
      },
      {
        ""Comment"": ""Come in sports uniform tomorrow"",
        ""SentBy"": ""P.T. Teacher"",
        ""SetDate"": ""07-05-2025"",
        ""SetTime"": ""13:00:03""
      },
      {
        ""Comment"": ""Submit fees"",
        ""SentBy"": ""Director"",
        ""SetDate"": ""08-05-2025"",
        ""SetTime"": ""10:07:41""
      }
    ]
    ";
        this.loginpageviewmodel.Announcement =
           new System.Collections.ObjectModel.ObservableCollection<AnnouncementData>(JsonConvert.DeserializeObject<List<AnnouncementData>>(jsondata));


        //    //File.ReadAllText(jsonFilePath);
        //    var announcements = JsonConvert.DeserializeObject<List<AnnouncementData>>(jsonData);

        //    // Ensure loginpageviewmodel is properly initialized  
        //    if (BindingContext is LoginPageViewModel viewModel)
        //    {
        //        viewModel.Announcement = new System.Collections.ObjectModel.ObservableCollection<AnnouncementData>(announcements);
        //    }
        //    else
        //    {
        //        Console.WriteLine("BindingContext is not of type LoginPageViewModel.");
        //    }
        //}
        //    else
        //    {
        //        Console.WriteLine("File not available");
        //    }


    }
}

