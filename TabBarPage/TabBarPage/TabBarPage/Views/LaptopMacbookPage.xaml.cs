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
    public partial class LaptopMacbookPage : ContentPage
    {
        LaptopMacbookViewModel _viewModel;

        public LaptopMacbookPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new LaptopMacbookViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}