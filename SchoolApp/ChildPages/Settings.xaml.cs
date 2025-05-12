namespace SchoolApp.ChildPages;

public partial class Settings : ContentPage
{
	public Settings()
	{
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Settings!" }
                }
        };
    }
}