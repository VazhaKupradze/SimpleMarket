using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {
        Product[] products = new Product[5];

        products[0] = new Product
        {
            Name = "PC Monitor",
            Category = "Electronics",
            Price = 4000m,
            Discount = 20,
            Quantity = 3
        };

        products[1] = new Product
        {
            Name = "PC Case",
            Category = "Electronics",
            Price = 2500m,
            Discount = 30,
            Quantity = 2
        };

        products[2] = new Product
        {
            Name = "Keyboard",
            Category = "Electronics",
            Price = 199.99m,
            Discount = 30,
            Quantity = 5
        };

        products[3] = new Product
        {
            Name = "Mouse",
            Category = "Electronics",
            Price = 99.99m,
            Discount = 20,
            Quantity = 2
        };

        products[4] = new Product
        {
            Name = "GPU",
            Category = "Electronics",
            Price = 5000m,
            Discount = 20,
            Quantity = 1
        };

        foreach (var product in products) 
        {
            product.CalculateFinalPrice();
            product.DisplayInfo();
        }
    }
}



