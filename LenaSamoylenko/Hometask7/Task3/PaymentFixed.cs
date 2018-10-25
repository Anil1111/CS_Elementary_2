using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class PaymentFixed : Payment
    {
        private double fixedSalary;
        public override double AvaregeMonthPayment()
        {
            double result = fixedSalary;
            return result;
        }
    }
}
