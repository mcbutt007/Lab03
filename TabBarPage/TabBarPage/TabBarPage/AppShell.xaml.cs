using System;
using System.Collections.Generic;
using TabBarPage.ViewModels;
using TabBarPage.Views;
using Xamarin.Forms;

namespace TabBarPage
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
