using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class LaptopGamingViewModel : BaseViewModel
    {
        public ObservableCollection<Laptop> Laptops { get; }
        public Command LoadLaptopsCommand { get; }

        public LaptopGamingViewModel()
        {
            Title = "Gaming Laptop";
            Laptops = new ObservableCollection<Laptop>();
            LoadLaptopsCommand = new Command(async () => await ExecuteLoadLaptopsCommand());

        }

        async Task ExecuteLoadLaptopsCommand()
        {
            IsBusy = true;

            try
            {
                Laptops.Clear();
                var items = await LaptopDataStore.GetLaptopsAsync(true);
                foreach (var item in items)
                {
                    Laptops.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}