using System;
using TabBarPage.Services;
using TabBarPage.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabBarPage
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);
            DependencyService.Register<MockDataStore>();
			DependencyService.Register<MockLaptopDataStore>();
            DependencyService.Register<MockSmartphoneDataStore>();
            DependencyService.Register<MockAccessoryDataStore>();
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
