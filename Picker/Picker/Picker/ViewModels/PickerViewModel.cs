using Picker.Models;
using Picker.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace Picker.ViewModels

{
    public class PickerViewModel : BaseViewModel
    {
        public ObservableCollection<City> Cities { get; }
        public Command LoadCitiesCommand { get; }
        public Command LoadPickerCommand { get; }
        //public Command AddCityCommand { get; }

        public PickerViewModel()
        {
            Title = "Picker";

            Cities = new ObservableCollection<City>();

            LoadCitiesCommand = new Command(async () => await ExecuteLoadCitiesCommand());

            LoadPickerCommand = new Command(async () => await LoadPickerCommandAsync());

            //CityTapped = new Command<City>(OnCitieselected);

        }

        private async Task LoadPickerCommandAsync()
        {
            var country = new string[]
{
    "Tất cả",
    "Việt Nam",
    "Đức",
    "Bồ Đào Nha"
};

            //Show confirmation dialog for choosing one.
            var result = await MaterialDialog.Instance.SelectChoiceAsync(title: "Chọn một đất nước",
                                                                         choices: country);
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