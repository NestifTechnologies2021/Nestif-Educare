namespace SchoolApp.ChildPages;

public partial class Onlinetest : ContentPage
{
	public Onlinetest()
	{
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Online-Test!" }
                }
        };
    }
}