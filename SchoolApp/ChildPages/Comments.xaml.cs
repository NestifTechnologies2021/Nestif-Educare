using SchoolApp.ViewModels;

namespace SchoolApp.ChildPages;

public partial class Comments : ContentPage
{
    public Comments()
    {
        //Content = new StackLayout
        //{
        //    Children = {
        //        new Label { Text = "Welcome to Comments!" }
        //        }
        //};
        InitializeComponent();
        BindingContext = new CommentsViewModel();

    }
}