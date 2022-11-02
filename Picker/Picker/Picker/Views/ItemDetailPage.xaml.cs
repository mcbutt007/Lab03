using Picker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Picker.Views
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