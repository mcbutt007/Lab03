using App_Shell_FlyoutPage.Services;
using App_Shell_FlyoutPage.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Shell_FlyoutPage
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
