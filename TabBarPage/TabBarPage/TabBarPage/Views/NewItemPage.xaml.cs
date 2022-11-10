using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabBarPage.Models;
using TabBarPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabBarPage.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}