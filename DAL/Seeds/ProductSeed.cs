using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public static class ProductSeed
    {
        public static void ProductSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    ProductID = 1, 
                    Name = "Milk", 
                    Contents = "Cow Milk", 
                    ExpireDate = new DateTime(2022, 01, 17), 
                    Price = 12, 
                    Stock = 0, 
                    StaffID = 3, 
                    InventoryDate = new(2021, 12, 27), 
                    CampaignID = 2 
                },
                new Product 
                { 
                    ProductID = 2, 
                    Name = "Butter", 
                    Contents = "Churned Cream, Salt", 
                    ExpireDate = new DateTime(2022, 02, 15), 
                    Price = 9, 
                    Stock = 13, 
                    StaffID = 3, 
                    InventoryDate = new(2022, 01, 02), 
                    CampaignID = 2 
                },
                new Product 
                { 
                    ProductID = 3, 
                    Name = "Yogurt", 
                    Contents = "Fremented Milk", 
                    ExpireDate = new DateTime(2022, 01, 10), 
                    Price = 14, 
                    Stock = 2, 
                    StaffID = 3, 
                    InventoryDate = new(2021, 12, 13), 
                    CampaignID = 2 
                },
                new Product 
                { 
                    ProductID = 4, 
                    Name = "White Bread", 
                    Contents = "Flour, Water", 
                    ExpireDate = new DateTime(2022, 01, 10), 
                    Price = 15, 
                    Stock = 22, 
                    StaffID = 1, 
                    InventoryDate = new(2021, 12, 03), 
                    CampaignID = 2 
                },
                new Product 
                { 
                    ProductID = 5, 
                    Name = "Whole Grain Bread", 
                    Contents = "Flour, Water, Oats", 
                    ExpireDate = new DateTime(2022, 01, 20), 
                    Price = 18, 
                    Stock = 9, 
                    StaffID = 3, 
                    InventoryDate = new(2021, 12, 29), 
                    CampaignID = 3 
                },
                new Product 
                { 
                    ProductID = 6, 
                    Name = "Baguette", 
                    Contents = "Flour, Water, Yeast", 
                    ExpireDate = new DateTime(2022, 01, 18), 
                    Price = 20, 
                    Stock = 15, 
                    StaffID = 3, 
                    InventoryDate = new(2021, 12, 23), 
                    CampaignID = null 
                },
                new Product 
                { 
                    ProductID = 7, 
                    Name = "Chicken", 
                    Contents = "Chicken", 
                    ExpireDate = new DateTime(2022, 02, 06), 
                    Price = 35, 
                    Stock = 26, 
                    StaffID = 2, 
                    InventoryDate = new(2021, 11, 16), 
                    CampaignID = 1 
                },
                new Product 
                { 
                    ProductID = 8, 
                    Name = "Steak", 
                    Contents = "Cow Meat, Fat", 
                    ExpireDate = new DateTime(2022, 03, 12), 
                    Price = 25, 
                    Stock = 11, 
                    StaffID = 2, 
                    InventoryDate = new(2021, 12, 28), 
                    CampaignID = 1 
                },
                new Product 
                { 
                    ProductID = 9, 
                    Name = "Fish", 
                    Contents = "Fish", 
                    ExpireDate = new DateTime(2022, 05, 15), 
                    Price = 30, 
                    Stock = 2, 
                    StaffID = 2, 
                    InventoryDate = new(2021, 12, 27), 
                    CampaignID = null 
                },
                new Product 
                { 
                    ProductID = 10, 
                    Name = "Water", 
                    Contents = "Water", 
                    ExpireDate = new DateTime(2022, 11, 24), 
                    Price = 5, 
                    Stock = 4, 
                    StaffID = 1, 
                    InventoryDate = new(2021, 12, 27), 
                    CampaignID = 3 
                },
                new Product 
                { 
                    ProductID = 11, 
                    Name = "Soda", 
                    Contents = "Carbonated Water, Flavor", 
                    ExpireDate = new DateTime(2022, 09, 25), 
                    Price = 15, 
                    Stock = 35, 
                    StaffID = 1, 
                    InventoryDate = new(2021, 12, 27), 
                    CampaignID = null 
                },
                new Product 
                { 
                    ProductID = 12, 
                    Name = "Beer", 
                    Contents = "Fermented Wheat", 
                    ExpireDate = new DateTime(2022, 07, 12), 
                    Price = 24, 
                    Stock = 15, 
                    StaffID = 5, 
                    InventoryDate = new(2021, 12, 23), 
                    CampaignID = 1 
                },
                new Product 
                { 
                    ProductID = 13, 
                    Name = "Apple", 
                    Contents = "", 
                    ExpireDate = new DateTime(2022, 02, 01), 
                    Price = 5, 
                    Stock = 14, 
                    StaffID = 4, 
                    InventoryDate = new(2021, 12, 26), 
                    CampaignID = 3 
                },
                new Product 
                { 
                    ProductID = 14, 
                    Name = "Orange", 
                    Contents = "", 
                    ExpireDate = new DateTime(2022, 01, 09), 
                    Price = 8, 
                    Stock = 25, 
                    StaffID = 4, 
                    InventoryDate = new(2021, 12, 30), 
                    CampaignID = 3 
                },
                new Product 
                { 
                    ProductID = 15, 
                    Name = "Melon", 
                    Contents = "", 
                    ExpireDate = new DateTime(2022, 02, 01), 
                    Price = 15, 
                    Stock = 1, 
                    StaffID = 3, 
                    InventoryDate = new(2021, 12, 17), 
                    CampaignID = 3 
                },
                new Product 
                { 
                    ProductID = 16, 
                    Name = "Flour", 
                    Contents = "Wheat",
                    ExpireDate = new DateTime(2022, 05, 15), 
                    Price = 10, 
                    Stock = 17, 
                    StaffID = 1, 
                    InventoryDate = new(2021, 12, 05), 
                    CampaignID = null 
                },
                new Product 
                { 
                    ProductID = 17, 
                    Name = "Canned Tomatoes", 
                    Contents = "Tomatoes", 
                    ExpireDate = new DateTime(2022, 03, 04), 
                    Price = 5, 
                    Stock = 0, 
                    StaffID = 5, 
                    InventoryDate = new(2021, 11, 10), 
                    CampaignID = null 
                },
                new Product 
                { 
                    ProductID = 18,
                    Name = "Cooking Oil", 
                    Contents = "", 
                    ExpireDate = new DateTime(2022, 06, 23), 
                    Price = 24, 
                    Stock = 21, 
                    StaffID = 5, 
                    InventoryDate = new(2021, 10, 30), 
                    CampaignID = null 
                });
        }
    }
}
