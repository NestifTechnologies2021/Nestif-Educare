using Microsoft.Maui.Controls;
using Microsoft.VisualBasic;
using SchoolApp.ViewModels;
using System.ComponentModel;


namespace SchoolApp.ChildPages;

public partial class Fees : ContentPage, INotifyPropertyChanged
{
    private DateTime dueDate;
   
    public Fees()
    {
        InitializeComponent();
        dueDate = DateTime.Now.AddDays(30); 
        BindingContext = new FeesViewModel() ;
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    private async void OnPayButtonClicked(object sender, EventArgs e)
    {
        var viewModel = (BindingContext as FeesViewModel);
        var selectedData = viewModel.Fees.Where(x => x.IsChecked).SingleOrDefault();
        string message = $"Do you want to proceed with the fees for Month of {selectedData?.FeeName} ? To be Paid = {selectedData?.FeeAmount}";
        
        bool proceed = await DisplayAlert("Alert!", message, "OK", "Cancel");
        //bool proceed = await DisplayAlert("Alert!", "Do you want to proceed ${selectedData}", "OK", "Cancel");
        if (proceed)
        {
            
            //await DisplayAlert("Info", "You chose to proceed.", "OK");
            var collection = viewModel.Fees;
            if (selectedData != null)
            {
                // Remove the selected data from the Fees collection
                collection.Remove(selectedData);
                viewModel.Fees = collection;
                OnPropertyChanged(nameof
                    (viewModel.Fees));
                // Optionally, you can navigate to another page and pass the selected data
                //await Navigation.PushAsync(new FeesPaid(selectedData));
            }

        }
        //else
        //{
        //    await DisplayAlert("Info", "You cancelled the action.", "OK");

        //}
    }

    private void OnSelectAllChanged(object sender, CheckedChangedEventArgs e)
    {
        bool isChecked = e.Value;
        
        foreach (var fee in (BindingContext as FeesViewModel).Fees)
        {
            fee.IsChecked = isChecked;
        }
        (BindingContext as FeesViewModel).UpdateCheckedStatus();
    }

    private void OnCheckboxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // Update the status of the button
        //(BindingContext as FeesViewModel).UpdateCheckedStatus();
        if (sender != null) {
            CheckBox checkbox = sender as CheckBox;
            PayButton.IsEnabled = checkbox.IsChecked;
        }
       
    }

    private async void OnPaidButtonClicked(object sender, EventArgs e)
    {

    }
}