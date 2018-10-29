using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Workers : IWorkersSort
    {
        List<Payment> workers = new List<Payment>();
        private Payment _payment;
        public Workers(Payment payment)
        {
            _payment = payment;
        }

        public void changePayment(Payment payment)
        {
            _payment = payment;
        }

        //автоматически определяется в конструкторе, но пусть будет
        private void AvarageMount()
        {
            _payment.AvaregeMonthPayment();
        }

        public void addWorkerToList()
        {
            workers.Add(_payment);
        }


        public List<Payment> SortWorkersInListByName(List<Payment> workers)
        {
            List<Payment> result = new List<Payment>();
            workers.OrderByDescending(f => f.fullName);
            //result = workers.OrderBy(f => f.fullName).ToList();
            return result;
        }

        public List<Payment> SortWorkersInListBySalary(List<Payment> workers)
        {
            List<Payment> result = new List<Payment>();
            result = workers.OrderBy(x => x.avaregePaymentForWorker);
            return result;
        }

        public void Print(List<Payment> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine(p.fullName, p.avaregePaymentForWorker);
            }
        }
    }
}
