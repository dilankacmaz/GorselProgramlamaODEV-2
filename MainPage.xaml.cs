using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace TodoOdev
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Items { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>();
            BindingContext = this;
        }

        private void AddItem_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewItemEntry.Text))
            {
                Items.Add(NewItemEntry.Text);
                NewItemEntry.Text = string.Empty;
            }
        }

       private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var item = (string)menuItem.BindingContext;
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        private async void GoToOtherPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Anasayfa());
        }
    }
}