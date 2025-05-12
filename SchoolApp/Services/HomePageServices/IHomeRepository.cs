using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Services.HomePageServices
{
    public interface IHomeRepository
    {
        Task<UserInfo> Home(string username);

    }
}
