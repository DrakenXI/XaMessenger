﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinMessenger.Models;

namespace XamarinMessenger.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = GetItems();
        }

        public List<Item> GetItems()
        {
            var listItems = new List<Item>();
            var jsonResult = new System.Net.WebClient().DownloadString("https://hmin309-embedded-systems.herokuapp.com/message-exchange/messages/");

            listItems = JsonConvert.DeserializeObject<List<Item>>(jsonResult);
            return listItems;
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.id == item.id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Item arg) => arg.id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            items.Clear();
            foreach(Item i in this.GetItems())
            {
                items.Add(i);
            }
            return await Task.FromResult(items);
        }
    }
}