using SQLite;
using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;

using XamarinMessenger.Models;
using XamarinMessenger.ViewModels;

namespace XamarinMessenger.Views
{
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        private readonly ItemDetailViewModel viewModel;

        private readonly string Filename = "Favorites.db"; // Used to store the favorite messages

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                student_message = "Test message",
                gps_lat = 0,
                gps_long = 0,
                student_id = 1
            };

            BindingContext = this.viewModel = new ItemDetailViewModel(item);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        // Add to favorites button
        public void OnButtonClicked(object sender, EventArgs args)
        {
            string filePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), Filename);
            SQLiteConnection connection = new SQLiteConnection(filePath);
            
            connection.CreateTable<Item>();
            connection.Insert(viewModel.SelectedItem);
        }
    }
}
