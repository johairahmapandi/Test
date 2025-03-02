using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using Test.Models;

namespace Test.ViewModels
{
    class DashboardViewModel : LocalBaseViewModel
    {
        public DashboardViewModel()
        {
            LoadItemCategories();
            LoadDailyDiscoverItemCollection();
        }

        public List<ItemCategory> Categories { get; set; }
        public List<Item> AllDailyDiscover { get; set; }
        public ObservableRangeCollection<ItemCategory> ItemCategories {  get; set; }

        public ObservableRangeCollection<Item> DailyDiscover { get; set; }

        public void LoadItemCategories()
        {
            ItemCategories = new ObservableRangeCollection<ItemCategory>();
            Categories = new List<ItemCategory>();

            Categories.Add(new ItemCategory
            {
                Name ="Clothes",
                Image="clothes_icon"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Shoes",
                Image = "heels_icon"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Accessories",
                Image = "jewellery_icon"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Bags",
                Image = "handbag_icon"
            });

            ItemCategories.AddRange(Categories);
        }

        public void LoadDailyDiscoverItemCollection()
        {
            DailyDiscover = new ObservableRangeCollection<Item>();
            

            DailyDiscover.Add(new Item
            {
                Name = "Women's Strapless Dress",
                Brand = "Shein",
                Image = "dress1",
                Price = "PHP 1,000.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "Van Cleef Bracelet",
                Brand = "Shein",
                Image = "jewelry2",
                Price = "PHP 1,000.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "Bow Small Shoulder Bag",
                Brand = "Shein",
                Image = "bag3",
                Price = "PHP 900.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "Pink Leather Watch",
                Brand = "Shein",
                Image = "jewelry3",
                Price = "PHP 1,200.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "Leather Slingback Heels",
                Brand = "Shein",
                Image = "shoe3",
                Price = "PHP 1,500.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "White Strap Dress",
                Brand = "Shein",
                Image = "dress3",
                Price = "PHP 1,000.00"
            });
            DailyDiscover.Add(new Item
            {
                Name = "White Small Shoulder Bag",
                Brand = "Shein",
                Image = "bag1",
                Price = "PHP 1,000.00"
            });
        }
    }
}
