using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.ViewModels
{
    public class ViewBase :BaseViewModel
    {
        /// <summary>
        /// Username
        /// </summary>
        ///
        
        public string? Username {  get; set; } 
        public string? Password { get; set; }
    }
}
