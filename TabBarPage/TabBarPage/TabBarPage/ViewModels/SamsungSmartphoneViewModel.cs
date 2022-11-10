using TabBarPage.Models;
using TabBarPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;

namespace TabBarPage.ViewModels
{
    public class SamsungSmartphoneViewModel : BaseViewModel
    {
        public ObservableCollection<Smartphone> Smartphones { get; }
        public Command LoadSmartphonesCommand { get; }
        public Command DeleteCommand { get; }
        public SamsungSmartphoneViewModel()
        {
            Title = "Samsung Smartphone";
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
                    if (smartphone.SmartphoneType == "Samsung")
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