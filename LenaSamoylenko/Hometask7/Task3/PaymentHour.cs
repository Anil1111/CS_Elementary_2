using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class PaymentHour : Payment
    {
        private double hourPrice;
        public override double AvaregeMonthPayment()
        {
            double result = 20.8 * 8 * hourPrice;
            return result;
        }
    }
}
