using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket
{
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
            Console.WriteLine("----------------------");

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

}
