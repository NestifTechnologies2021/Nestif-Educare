using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Models;

namespace SchoolApp.Services
{
  
        public interface IAnnouncementRepository
        {
            Task<List<AnnouncementData>> GetAnnouncements();
        }
    

}
