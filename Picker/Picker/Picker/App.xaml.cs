using Picker.Services;
using Picker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Picker
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<CityDataStore>();
            DependencyService.Register<CountryDataStore>();
            XF.Material.Forms.Material.Init(this);
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
