namespace SchoolApp.ChildPages;

public partial class Profile : ContentPage
{
	public Profile()
	{
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Profile!" }
                }
        };
    }
}