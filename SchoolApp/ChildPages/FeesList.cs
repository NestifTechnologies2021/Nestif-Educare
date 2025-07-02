using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.ChildPages
{
    public class Fee
    {
        public string FeeName { get; set; }
        public double FeeAmount { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsChecked { get;  set; }
    }
    
}
