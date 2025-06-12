using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket.Entities
{
    internal class Order
    {
        public decimal Price { get; set; }
        public decimal ShippingPrice { get; set; }

        public List<Product> Products { get; set; }
        public Custumer Custumer { get; set; }
    }
}
