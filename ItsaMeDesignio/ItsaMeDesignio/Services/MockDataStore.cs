using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItsaMeDesignio.Models;

namespace ItsaMeDesignio.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "The region that encapsulates Scandinavia and Northern Europe is enjoying.",
                    Text = "Asia",
                    Subtitle = "& australia",
                    Price = 319
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Marvel at the unmatched beauty of Greece, Italy, Spain and southern France.",
                    Text = "Scandinavian",
                    Subtitle = "& northern",
                    Price = 521
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "The region that encapsulates Scandinavia and Northern Europe is enjoying.",
                    Text = "Sky Princess",
                    Subtitle = "debuts in fall",
                    Price = 743
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "Experience colorful Barcelona and sample the world's finest wines. ",
                    Text = "Experience",
                    Subtitle = "amazing",
                    Price = 319
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "The region that encapsulates Scandinavia and Northern Europe is enjoying.",
                    Text = "Asia",
                    Subtitle = "& australia",
                    Price = 521
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Marvel at the unmatched beauty of Greece, Italy, Spain and southern France.",
                    Text = "Scandinavian",
                    Subtitle = "& northern",
                    Price = 743
                }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}