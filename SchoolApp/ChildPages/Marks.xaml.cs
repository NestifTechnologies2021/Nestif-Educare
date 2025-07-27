using SchoolApp.ViewModels;

namespace SchoolApp.ChildPages;

public partial class Marks : ContentPage
{
    public Marks()
    {
        InitializeComponent();
        BindingContext = new MarksViewModel();
       // LoadMarks();
    }

    //private void LoadMarks()
    //{
    //    var mark = new List<Subjects>
    //        {
    //         new Subjects { SubjectName = "Maths", Marks = 85.00 }
    //        };
    //   //SubjectMarksListView.ItemsSource = mark;
    //}
}


