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

            Order order1 = new Order();
            order1.zapisDannih();
            //foreach(object obj in order1.zapis)
            //{
            //    Console.WriteLine(obj);
            //}
            Order order2 = new Order();
            order2.zapisDannih();
            Console.WriteLine();//Dlya lychshei chitaemosti v konsoly

            Order[] orders = new Order[] { order1, order2};
            Array.Sort(orders);

            foreach (Order o in orders)
            {
                Console.WriteLine("{0}", o.zapis);
            }

            Console.WriteLine("Введите сумму для сравнения:");
            int summaDlyaVivoda = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i>orders.Length;++i)
            {
                if(order1.summaPerevoda > summaDlyaVivoda)
                {
                    
                    if(order2.summaPerevoda < summaDlyaVivoda)
                    {

                    }
                }
                else
                {
                    foreach (Order o in orders)
                    {
                        Console.WriteLine(o);
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
