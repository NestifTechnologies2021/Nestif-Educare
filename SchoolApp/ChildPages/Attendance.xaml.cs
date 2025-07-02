namespace SchoolApp.ChildPages;

public partial class Attendance : ContentPage
{
    public Attendance()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Attendance!" }
                }
        };
    }
}

