using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SchoolApp.ViewModels
{
   public class NoticeViewModel
    {
        //public string Message { get; set; }
        public ObservableCollection<Notices> Notice { get; set; }
        public NoticeViewModel()
        {
            Notice = new ObservableCollection<Notices>
        {
            new Notices { Header = "Class Announcement",Message = "Class will be held in Room 101." ,Messenger = "Maths Teacher",
                DateTime = DateTime.Now },
            new Notices { Header = "Meeting Reminder", Message = "Parent-Teacher Meeting on Friday." ,Messenger = "Class Teacher",
                DateTime = DateTime.Now }
        };
        }
    }

    public class Notices
    {
        public string Header { get; set; }
        public string Message { get; set; }
        public string Messenger { get; set; }
        public DateTime DateTime { get; set; }
    }
}
