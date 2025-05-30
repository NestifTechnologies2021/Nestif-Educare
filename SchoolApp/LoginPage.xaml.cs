using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class LoginPage : ContentPage
{
	
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginPageViewModel;
		
	}
    private void OnUsernameTextChanged(object sender, TextChangedEventArgs e)
    {
        Button button = (Button)FindByName("loginBtn");

        var newText = e.NewTextValue;
        button.IsEnabled = !string.IsNullOrWhiteSpace(newText);
    }


}