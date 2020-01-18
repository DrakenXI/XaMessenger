using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMessenger.Models;
using XamarinMessenger.Views;

namespace XamarinMessenger.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item SelectedItem { get; set; }
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemDetailViewModel(Item selectedItem = null)
        {
            Title = selectedItem?.student_message;
            SelectedItem = selectedItem;
            Items = new ObservableCollection<Item>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            MessagingCenter.Subscribe<MapPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    if (item.student_id == this.SelectedItem.student_id)
                        Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
