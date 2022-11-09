using App_Shell_FlyoutPage.Models;
using App_Shell_FlyoutPage.ViewModels;
using App_Shell_FlyoutPage.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Shell_FlyoutPage.Views
{
    public partial class LaptopGamingPage : ContentPage
    {
        LaptopGamingViewModel _viewModel;

        public LaptopGamingPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new LaptopGamingViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}