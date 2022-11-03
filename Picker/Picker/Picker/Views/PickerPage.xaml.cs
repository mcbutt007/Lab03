using Picker.Models;
using Picker.ViewModels;
using Picker.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI.Dialogs;

namespace Picker.Views
{
    public partial class PickerPage : ContentPage
    {
        PickerViewModel _viewModel;

        public PickerPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PickerViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}