using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SchoolApp.ChildPages;

namespace SchoolApp.ViewModels
{
    public partial class FeesViewModel : INotifyPropertyChanged
    {
        private string _name;
        private bool isChecked;
        private ObservableCollection<Fee> fees ;

        public ICommand ButtonCommand { get; set; }

        public ObservableCollection<Fee> Fees {
            get => fees;
            set
            {
                if (fees != value)
                {
                    fees = value;
                    OnPropertyChanged(nameof(IsChecked));
                }
            }
        }

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                }
            }
        }
        public FeesViewModel()
        {
            GetFeesList();
           


        }

        public void UpdateCheckedStatus()
        {
         var   _isChecked = Fees.Any(f => f.IsChecked);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private void GetFeesList()
        {
            Fees = new ObservableCollection<Fee>()
            {
                new Fee(){
                DueDate=  new DateTime(2025,4,15),
                FeeAmount = 1000,
                FeeName ="April",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2025,5,15),
                FeeAmount = 1000,
                FeeName ="May",
                IsChecked = false
                },
                new Fee(){ 
                DueDate=  new DateTime(2025,6,15),
                FeeAmount = 1000,
                FeeName ="June",
                IsChecked = false
                },
                new Fee(){
                DueDate=   new DateTime(2025,7,15),
                FeeAmount = 1000,
                FeeName ="July",
                IsChecked = false
                },
                new Fee(){
                DueDate=   new DateTime(2025,8,15),
                FeeAmount = 1500,
                FeeName ="August",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2025,9,15),
                FeeAmount = 1000,
                FeeName ="September",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2025,10,15),
                FeeAmount = 1000,
                FeeName ="October",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2025,11,15),
                FeeAmount = 1000,
                FeeName ="November",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2025,12,15),
                FeeAmount = 1500,
                FeeName ="December",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2026,1,15),
                FeeAmount = 1000,
                FeeName ="January",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2026,2,15),
                FeeAmount = 1000,
                FeeName ="February",
                IsChecked = false
                },
                new Fee(){
                DueDate=  new DateTime(2026,3,15),
                FeeAmount = 1500,
                FeeName ="March",
                IsChecked = false
                },

            };
        }
    }
}
