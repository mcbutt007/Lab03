using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.ViewModels
{
    public class SonySmartphoneViewModel : BaseViewModel
    {
        public ObservableCollection<Smartphone> Smartphones { get; }
        public Command LoadSmartphonesCommand { get; }

        public SonySmartphoneViewModel()
        {
            Title = "Sony Smartphone";
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
                    if (smartphone.SmartphoneType == "Sony")
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