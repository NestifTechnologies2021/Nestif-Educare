namespace SchoolApp.ChildPages;

public partial class Marks : ContentPage
{
    public Marks()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Marks!" }
                }
        };
    }
}