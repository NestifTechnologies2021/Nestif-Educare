namespace SchoolApp.ChildPages;

public partial class Onlineclass : ContentPage
{
	public Onlineclass()
	{
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Online-Class!" }
                }
        };
    }
}