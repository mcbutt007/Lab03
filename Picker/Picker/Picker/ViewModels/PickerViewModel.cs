using Picker.Models;
using Picker.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace Picker.ViewModels

{
    public class PickerViewModel : BaseViewModel
    {
        public ObservableCollection<City> Cities { get; }
        public ObservableCollection<Country> Countries { get; }
        public Command LoadCitiesCommand { get; }
        public Command LoadPickerCommand { get; }
        //public Command AddCityCommand { get; }

        public PickerViewModel()
        {
            Title = "Picker";

            Cities = new ObservableCollection<City>();

            Countries = new ObservableCollection<Country>();

            LoadCitiesCommand = new Command(async () => await ExecuteLoadCitiesCommand());

            LoadPickerCommand = new Command(async () => await LoadPickerCommandAsync());

            //CityTapped = new Command<City>(OnCitieselected);

        }

        private async Task LoadPickerCommandAsync()
        {
            List<string> countrylist = new List<string>
            {
                "Tất cả"
            };
            Countries.Clear();
            var countries = await CountryDataStore.GetCountriesAsync(true);
            foreach (var country in countries)
            {
                countrylist.Add(country.CountryName);
            }
            String[] str = countrylist.ToArray();
            //Show confirmation dialog for choosing one.
            var result = await MaterialDialog.Instance.SelectChoiceAsync(title: "Chọn một đất nước", choices: str);
            if (result != -1)
            {
                            IsBusy = true;
            try
            {
                Cities.Clear();
                var cities = await CityDataStore.GetCitiesAsync(true);
                foreach (var city in cities)
                {
                    if (result.ToString() != "0" && city.CountryID == result.ToString())
                        Cities.Add(city);
                    else if (result.ToString() == "0")
                        Cities.Add(city);
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
        }

        async Task ExecuteLoadCitiesCommand()
        {
            IsBusy = true;

            try
            {
                Cities.Clear();
                var cities = await CityDataStore.GetCitiesAsync(true);
                foreach (var city in cities)
                {
                    Cities.Add(city);
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

        //async void OnCitieselected(City City)
        //{
        //    if (City == null)
        //        return;

        //    // This will push the CityDetailPage onto the navigation stack
        //    // await Shell.Current.GoToAsync($"{nameof(CityDetailPage)}?{nameof(CityDetailViewModel.CityId)}={City.Id}");
        //}
    }
}