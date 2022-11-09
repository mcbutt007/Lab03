using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class IphoneViewModel : BaseViewModel
    {
        public ObservableCollection<Smartphone> Smartphones { get; }
        public Command LoadSmartphonesCommand { get; }

        public IphoneViewModel()
        {
            Title = "Iphone";
            Smartphones = new ObservableCollection<Smartphone>();
            LoadSmartphonesCommand = new Command(async () => await ExecuteLoadSmartphonesCommand());

        }

        async Task ExecuteLoadSmartphonesCommand()
        {
            IsBusy = true;

            try
            {
                Smartphones.Clear();
                var smartphones = await SmartphoneDataStore.GetSmartphonesAsync(true);
                foreach (var smartphone in smartphones)
                {
                    if (smartphone.SmartphoneType == "Iphone")
                        Smartphones.Add(smartphone);
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