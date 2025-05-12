namespace SchoolApp.ChildPages;
using Newtonsoft;
using Newtonsoft.Json;
using SchoolApp.Models;
using SchoolApp.ViewModels;
using SchoolApp.Views;
using System.Collections;
using System.Threading.Tasks;

public partial class Announcement : ContentPage
{
    public Announcement()
    {
        InitializeComponent();
       
    }

    public Announcement(LoginPageViewModel loginPageViewModel)
    {
        //loginPageViewModel.UserName = "Announcemnt  " + loginPageViewModel.UserName;
        //if (loginPageViewModel.Password != null) 
        InitializeComponent();
        this.BindingContext = loginPageViewModel;
        
    }

    private void LoadAnnouncements()
    {
        
        var jsonFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Announcement.json");
        if (File.Exists(jsonFilePath))
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            var announcements = JsonConvert.DeserializeObject<List<AnnouncementData>>(jsonData);

            // Binding the announcements to a ListView
           
            announcementsListView.ItemsSource = announcements;
        }
        else
        {
            Console.WriteLine("File not available");
        }
    }
}

