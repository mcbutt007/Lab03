using App_Shell_FlyoutPage.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_Shell_FlyoutPage.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}