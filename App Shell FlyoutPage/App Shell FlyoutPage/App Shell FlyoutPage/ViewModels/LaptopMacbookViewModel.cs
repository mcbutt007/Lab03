using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class LaptopMacbookViewModel : BaseViewModel
    {
        public ObservableCollection<Laptop> Laptops { get; }
        public Command LoadLaptopsCommand { get; }

        public LaptopMacbookViewModel()
        {
            Title = "Macbook Laptop";
            Laptops = new ObservableCollection<Laptop>();
            LoadLaptopsCommand = new Command(async () => await ExecuteLoadLaptopsCommand());

        }

        async Task ExecuteLoadLaptopsCommand()
        {
            IsBusy = true;

            try
            {
                Laptops.Clear();
                var laptops = await LaptopDataStore.GetLaptopsAsync(true);
                foreach (var laptop in laptops)
                {
                    if (laptop.LaptopType == "Macbook")
                        Laptops.Add(laptop);
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