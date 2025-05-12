namespace SchoolApp.ChildPages;

public partial class EContent : ContentPage
{
    public EContent()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to E-Content!" }
                }
        };
    }
}