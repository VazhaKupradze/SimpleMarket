using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarket.Entities
{
    internal class Payment
    {
        public Custumer PayedBy { get; set; }
        public string PaymentMethod { get; set; }

    }
}
