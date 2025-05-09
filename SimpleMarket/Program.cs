using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {

            var product = new Product();

            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();
            product.Name = name;


            Console.WriteLine("Enter product category");
            var category = Console.ReadLine();
            product.Category = category;


            Console.WriteLine("Enter product price");
            var price = Console.ReadLine();
            product.Price = decimal.Parse(price);


            Console.WriteLine("Enter product discount");
            var discount = Console.ReadLine();
            product.Discount = decimal.Parse(discount);


            Console.WriteLine("Enter product Quantity");
            var quantity = Console.ReadLine();
            product.Quantity = int.Parse(quantity);


            DataBase.Products.Add(product);

            Console.WriteLine("to continue press Y");
            var answer = Console.ReadLine();
            if (answer.ToUpper() != "Y")
            {
                break;
            }
        }

        foreach (var product in DataBase.Products)
        {
            product.CalculateFinalPrice();
            product.DisplayInfo();
        }

    }
}



