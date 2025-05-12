using Newtonsoft.Json;
using SchoolApp.Models;
using SchoolApp.Services.HomePageServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Services.HomePageServices
{

    public class HomeService : IHomeRepository
    {
        public async Task<UserInfo?> Home(string username)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new List<UserInfo>();
                    var client = new HttpClient();

                    string url = "http://192.168.1.107:8099/api/UserInfoes/HomeUser/" + username ;
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        userInfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
                        return await Task.FromResult(userInfo.FirstOrDefault());
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
