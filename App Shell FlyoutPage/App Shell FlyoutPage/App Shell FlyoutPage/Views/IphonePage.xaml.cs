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
    public partial class IphonePage : ContentPage
    {
        IphoneViewModel _viewModel;

        public IphonePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new IphoneViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}