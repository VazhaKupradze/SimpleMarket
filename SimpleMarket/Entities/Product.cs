using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket.Entities
{
    public class Product
    {
        public string Name { get; set; }

        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountedAmount { get; set; }
        public decimal FinalPrice { get; set; }
        public int Quantity { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Discount: {Discount}");
            Console.WriteLine($"Discounted Amount: {DiscountedAmount}");
            Console.WriteLine($"Final Price: {FinalPrice}");
            Console.WriteLine("----------------------");

        }

        public void CalculateFinalPrice()
        {
            DiscountedAmount = Price * Discount / 100;
            FinalPrice = Price - DiscountedAmount;
        }

        public void CalculateFinalPrice(decimal price)
        {
            Console.WriteLine(price);
        }

        public void CalculateFinalPrice(decimal price, string rame)
        {
            Console.WriteLine(price);
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

}
