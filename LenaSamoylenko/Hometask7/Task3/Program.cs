using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentFixed worker1 = new PaymentFixed("Vasya Vasyliev", 5000);
            PaymentFixed worker2 = new PaymentFixed("Ivan Ivanov", 7000);
            PaymentHour worker3 = new PaymentHour("Aleksandr Titov", 50);


            Workers workers = new Workers(worker1);
            workers.addWorkerToList(worker1);
            workers.addWorkerToList(worker2);
            workers.addWorkerToList(worker3);


            List<Payment> workers1 = workers.SortWorkersInListByName();
            workers.Print(workers1);

            Console.WriteLine("\nAnother order\n");

            List<Payment> workers2 = workers.SortWorkersInListBySalary();
            workers.Print(workers2);
            Console.ReadKey();
        }
    }
}
