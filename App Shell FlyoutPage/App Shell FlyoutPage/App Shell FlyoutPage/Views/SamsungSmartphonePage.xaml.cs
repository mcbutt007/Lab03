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
    public partial class SamsungSmartphonePage : ContentPage
    {
        SamsungSmartphoneViewModel _viewModel;

        public SamsungSmartphonePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SamsungSmartphoneViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}