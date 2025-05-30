using SchoolApp.ChildPages;
using SchoolApp.ViewModels;

namespace SchoolApp.Views;


public partial class HomePage : ContentPage
{
    private object loginPageViewModel;

    public LoginPageViewModel LoginPageViewModel { get; }

    public HomePage()
    {
        InitializeComponent();
    }
    
    public HomePage(LoginPageViewModel loginPageViewModel)
    {
    InitializeComponent();
      this.LoginPageViewModel = loginPageViewModel;

    if (loginPageViewModel.Password != null) { }
    LoginPageViewModel = loginPageViewModel;
   this.BindingContext = LoginPageViewModel;

    }

    private async void Announcement_Clicked(object sender, EventArgs e)
    {
          await Navigation.PushAsync(new Announcement(LoginPageViewModel));
    }

    private async void Homework_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homework());
    }

    private async void Attendance_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Attendance());
    }

    private async void Marks_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Marks());
    }

    private async void EContent_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EContent());
    }

    private async void Fees_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Fees());
    }

    private async void Annual_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Annualcalendar());
    }

    private async void Comments_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Comments());
    }

    private async void Bus_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Bus());
    }

    private async void Notice_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notice());
    }

    private async void Profile_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Profile());
    }

    private async void Settings_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Settings());
    }

    private async void Oclass_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Onlineclass());
    }

    private async void Otest_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Onlinetest());
    }
}