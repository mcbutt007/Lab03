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
    public partial class HeadphonePage : ContentPage
    {
        HeadphoneViewModel _viewModel;

        public HeadphonePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new HeadphoneViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}