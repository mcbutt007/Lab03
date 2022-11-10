using TabBarPage.Models;
using TabBarPage.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabBarPage.ViewModels
{
    public class SamsungSmartphoneViewModel : BaseViewModel
    {
        public ObservableCollection<Smartphone> Smartphones { get; }
        public Command LoadSmartphonesCommand { get; }
        public Command DeleteCommand { get; }
        public Command FavoriteCommand { get; }
        public Command ShareCommand { get; }

        public SamsungSmartphoneViewModel()
        {
            Title = "Samsung Smartphone";
            Smartphones = new ObservableCollection<Smartphone>();
            LoadSmartphonesCommand = new Command(async () => await ExecuteLoadSmartphonesCommand());
            DeleteCommand = new Command(async () => await App.Current.MainPage.DisplayAlert("Alert","Delete","OK"));
            FavoriteCommand = new Command(async () => await App.Current.MainPage.DisplayAlert("Alert", "Favorite", "OK"));
            ShareCommand = new Command(async () => await App.Current.MainPage.DisplayAlert("Alert", "Share", "OK"));
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