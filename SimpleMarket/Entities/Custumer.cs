using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket.Entities
{
    internal class Custumer : Person
    {
        public int IBanNumber { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"IBanNumber: {IBanNumber}");
            base.DisplayInfo();
        }
    }
}
