using System;

using XamarinMessenger.Models;

namespace XamarinMessenger.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.student_message;
            Item = item;
        }
    }
}
