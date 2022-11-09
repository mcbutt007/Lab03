using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Laptop> Laptops { get; }
        public ObservableCollection<Smartphone> Smartphones { get; }
        public ObservableCollection<Accessory> Accessories { get; }
        public ObservableCollection<Electronic> Electronics { get; }
        public Command LoadElectronicsCommand { get; }

        public HomeViewModel()
        {
            Title = "Home";
            Laptops = new ObservableCollection<Laptop>();
            Smartphones = new ObservableCollection<Smartphone>();
            Accessories = new ObservableCollection<Accessory>();
            Electronics= new ObservableCollection<Electronic>();
            LoadElectronicsCommand = new Command(async () => await ExecuteLoadElectronicsCommand());

        }

        async Task ExecuteLoadElectronicsCommand()
        {
            IsBusy = true;

            try
            {
                Electronics.Clear();
                var laptops = await LaptopDataStore.GetLaptopsAsync(true);
                foreach (var laptop in laptops)
                {
                    Electronics.Add(new Electronic
                    {
                        ElectronicID = laptop.LaptopID,
                        ElectronicImage = laptop.LaptopImage,
                        ElectronicName= laptop.LaptopName,
                        ElectronicPrice= laptop.LaptopPrice,
                        ElectronicRatings= laptop.LaptopRatings
                    });
                }
                var smartphones = await SmartphoneDataStore.GetSmartphonesAsync(true);
                foreach (var smartphone in smartphones)
                {
                    Electronics.Add(new Electronic
                    {
                        ElectronicID = smartphone.SmartphoneID,
                        ElectronicImage = smartphone.SmartphoneImage,
                        ElectronicName = smartphone.SmartphoneName,
                        ElectronicPrice = smartphone.SmartphonePrice,
                        ElectronicRatings = smartphone.SmartphoneRatings
                    });
                }
                var accessories = await AccessoryDataStore.GetAccessoriesAsync(true);
                foreach (var accessory in accessories)
                {
                    Electronics.Add(new Electronic
                    {
                        ElectronicID = accessory.AccessoryID,
                        ElectronicImage = accessory.AccessoryImage,
                        ElectronicName = accessory.AccessoryName,
                        ElectronicPrice = accessory.AccessoryPrice,
                        ElectronicRatings = accessory.AccessoryRatings
                    });
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