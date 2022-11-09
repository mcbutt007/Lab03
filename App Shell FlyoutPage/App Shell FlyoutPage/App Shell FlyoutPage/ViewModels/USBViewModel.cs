using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class USBViewModel : BaseViewModel
    {
        public ObservableCollection<Accessory> Accessories { get; }
        public Command LoadAccessoriesCommand { get; }

        public USBViewModel()
        {
            Title = "USB";
            Accessories = new ObservableCollection<Accessory>();
            LoadAccessoriesCommand = new Command(async () => await ExecuteLoadAccessoriesCommand());

        }

        async Task ExecuteLoadAccessoriesCommand()
        {
            IsBusy = true;

            try
            {
                Accessories.Clear();
                var accessories = await AccessoryDataStore.GetAccessoriesAsync(true);
                foreach (var accessory in accessories)
                {
                    if (accessory.AccessoryType == "USB")
                        Accessories.Add(accessory);
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