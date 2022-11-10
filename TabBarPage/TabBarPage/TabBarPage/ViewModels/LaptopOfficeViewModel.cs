using TabBarPage.Models;
using TabBarPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabBarPage.ViewModels
{
    public class LaptopOfficeViewModel : BaseViewModel
    {
        public ObservableCollection<Laptop> Laptops { get; }
        public Command LoadLaptopsCommand { get; }

        public LaptopOfficeViewModel()
        {
            Title = "Office Laptop";
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
                    if (laptop.LaptopType=="Office")
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