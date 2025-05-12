namespace SchoolApp.ChildPages;

public partial class Homework : ContentPage
{
    //public Homework()
    //{
    //	InitializeComponent();
    //}
    public Homework()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Homework!" }
                }
        };
    }
}