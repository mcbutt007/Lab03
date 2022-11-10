using System.ComponentModel;
using TabBarPage.ViewModels;
using Xamarin.Forms;

namespace TabBarPage.Views
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