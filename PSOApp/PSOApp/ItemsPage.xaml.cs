using System;
using System.Collections.Generic;
using Android;
using Xamarin.Forms;

namespace PSOApp
{
    public partial class ItemsPage : ContentPage
    {
        public IList<ItemModel> itemList { get; private set; }
        public ItemsPage()
        {
            InitializeComponent();

            itemList = App.dm.GetAllItems();
            BindingContext = this;
        }
    }
}
