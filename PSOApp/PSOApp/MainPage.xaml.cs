using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSOApp
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //List<ItemModel> items = PSOApp.App.dm.GetAllItems();
        }

        //Item button clicked
        async void ItemsButtonClicked(object sender, System.EventArgs e) {
            ItemsPage itemsPage = new ItemsPage();
            await Navigation.PushAsync(itemsPage);
        }
    }
}
