namespace SchoolApp.ChildPages;

public partial class Bus : ContentPage
{
    public Bus()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Bus Location!" }
                }
        };
    }
}