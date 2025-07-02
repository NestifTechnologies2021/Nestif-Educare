using SchoolApp.ViewModels;

namespace SchoolApp.ChildPages;

public partial class Notice : ContentPage
{
	public Notice()
	{
        //Content = new StackLayout
        //{
        //    Children = {
        //        new Label { Text = "Welcome to Notice Board!" }
        //        }
        //};

        InitializeComponent();
        BindingContext = new NoticeViewModel();
    }
}