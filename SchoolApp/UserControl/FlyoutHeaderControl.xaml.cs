using System.Diagnostics;

namespace SchoolApp.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if(App.UserInfo != null)
		{
			lblUserName.Text = "Logged in as: " + App.UserInfo.UserName;
            lblUserEmail.Text = App.UserInfo.UserName; //set email from api

        }
	}
}