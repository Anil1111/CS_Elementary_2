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

        public PaymentHour(string fullName, double HourPrice)
        {
            base.fullName = fullName;
            hourPrice = HourPrice;
            base.avaregePaymentForWorker = AvaregeMonthPayment();
        }

        public override double AvaregeMonthPayment()
        {
            double result = 20.8 * 8 * hourPrice;
            return result;
        }
    }
}
