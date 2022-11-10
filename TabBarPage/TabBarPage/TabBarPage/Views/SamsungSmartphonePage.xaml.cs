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
using XF.Material.Forms.UI.Dialogs;

namespace TabBarPage.Views
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

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            MaterialDialog.Instance.ConfirmAsync(message: "Do you want to delete it?",
                                    confirmingText: "Yes",
                                    dismissiveText: "No");
        }
    }
}