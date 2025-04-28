using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {

        Product product = new Product();



        Console.WriteLine("Enter product Name:");
        var name = Console.ReadLine();
        product.Name = name;

        Console.WriteLine("Enter product Category:");
        var category = Console.ReadLine();
        product.Category = category;

        Console.WriteLine("Enter product Price:");
        var price = Console.ReadLine();
        product.Price = decimal.Parse(price);


        Console.WriteLine("Enter product Discount:");
        var discount = Console.ReadLine();
        product.Discount = decimal.Parse(discount);

        Console.WriteLine("Enter product Quantity");
        var quantity = Console.ReadLine();
        product.Quantity = int.Parse(quantity);



        product.CalculateFinalPrice();

        Console.WriteLine("------------------------------");
        product.DisplayInfo();

        bool inStok = product.IsAvailable();

        Console.WriteLine(inStok);
    }

}

public class Product
{
    public string Name;
    public string Category;
    public decimal Price;
    public decimal Discount;
    public decimal DiscountedAmount;
    public decimal FinalPrice;
    public int Quantity;

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Discount: {Discount}");
        Console.WriteLine($"Discounted Amount: {DiscountedAmount}");
        Console.WriteLine($"Final Price: {FinalPrice}");


    }

    public void CalculateFinalPrice()
    {
        DiscountedAmount = (Price * Discount) / 100;
        FinalPrice = Price - DiscountedAmount;
    }

    public bool IsAvailable()
    {
        if (Quantity > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


