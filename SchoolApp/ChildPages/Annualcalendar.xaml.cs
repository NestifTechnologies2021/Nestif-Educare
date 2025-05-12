namespace SchoolApp.ChildPages;
using SchoolApp.Views;
public partial class Annualcalendar : ContentPage
{
    public Annualcalendar()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to Annual Calendar!" }
                }
        };
    }
}