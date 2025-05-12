namespace SchoolApp.ChildPages;

public partial class Fees : ContentPage
{
    public Fees()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Fees Payment!" }
                }
        };
    }
}