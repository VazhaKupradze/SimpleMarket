using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket.Entities
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override void DisplayInfo()
        {

            Console.WriteLine($"Salary: {Salary}");
            base.DisplayInfo();
        }
    }
}
