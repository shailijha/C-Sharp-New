using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        public void Promote()
        {
            var calc = new RateCalculator();
            var rating = calc.Calculate(this);

        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
