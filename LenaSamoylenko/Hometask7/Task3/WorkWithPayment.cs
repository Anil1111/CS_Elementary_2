using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class WorkWithPayment
    {
        private Payment _payment;
        public Payment Payment => _payment;
        public WorkWithPayment(Payment payment)
        {
            _payment = payment;
        }

        public void SetStrategy(Payment payment)
        {
            _payment = payment;
        }

        public void ExecuteAvarageMonthPayment()
        {
            //_payment.
        }

    }
}
