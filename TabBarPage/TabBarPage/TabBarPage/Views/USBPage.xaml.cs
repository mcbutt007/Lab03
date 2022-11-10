using TabBarPage.Models;
using TabBarPage.ViewModels;
using TabBarPage.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabBarPage.Views
{
    public partial class USBPage : ContentPage
    {
        USBViewModel _viewModel;

        public USBPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new USBViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}