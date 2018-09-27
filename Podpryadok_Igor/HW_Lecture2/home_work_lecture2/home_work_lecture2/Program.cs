using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace home_work_lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.zapisWorker();

            Worker[] workers = new Worker[] { worker1};
            Array.Sort(workers);
            foreach(Worker w in workers)
            {
                Console.WriteLine(w.nameFO);
            }

            Order order1 = new Order();
            order1.zapisDannih();

            Order order2 = new Order();
            order2.zapisDannih();
            Console.WriteLine();//Dlya lychshei chitaemosti v konsoly

            Order[] orders = new Order[] { order1, order2};
            Array.Sort(orders);
            foreach (Order o in orders)
            {
                Console.WriteLine(o.zapis);
            }

            
            
            Console.ReadLine();
        }
    }
}
