using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.ChildPages;
using SchoolApp.ViewModels;
//using static SchoolApp.ViewModels.LoginPageViewModel;

namespace SchoolApp.Services
{
    public class AnnouncementService : IAnnouncementRepository
    {
        public async Task<List<Announcement>> GetAnnouncements()
        {
            
            var announcements = new List<Announcement>();
            
            return announcements;
        }

        Task<List<Models.AnnouncementData>> IAnnouncementRepository.GetAnnouncements()
        {
            throw new NotImplementedException();
        }
    }
}
