using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket
{
    internal static class DataBase
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
                    {
                        Name = "PC Monitor",
                        Category = "Electronics",
                        Price = 4000m,
                        Discount = 20,
                        Quantity = 3
                    },
            new Product
                    {
                        Name = "PC Case",
                        Category = "Electronics",
                        Price = 2500m,
                        Discount = 30,
                        Quantity = 2
                    },
            new Product
                    {
                        Name = "Keyboard",
                        Category = "Electronics",
                        Price = 199.99m,
                        Discount = 30,
                        Quantity = 5
                    },
            new Product
                    {
                        Name = "Mouse",
                        Category = "Electronics",
                        Price = 99.99m,
                        Discount = 20,
                        Quantity = 2
                    },
            new Product
                    {
                        Name = "GPU",
                        Category = "Electronics",
                        Price = 5000m,
                        Discount = 20,
                        Quantity = 1
                    }
        };
    }
}
