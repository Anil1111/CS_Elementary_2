using System;
using System.Collections.Generic;
using System.Text;

namespace home_work_lecture2
{
    class vivodDanih
    {
        public void vivodOrder(int obj1, int obj2, Array orders)
        {
            Console.WriteLine("Введите сумму для сравнения:");
           
            int summaDlyaVivoda = Convert.ToInt32(Console.ReadLine());

            if (obj1 > summaDlyaVivoda || obj2 > summaDlyaVivoda)
            {
                int i = 1;
                if (obj2 > summaDlyaVivoda)
                {
                    for( i=2; i > orders.Length; ++i)
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    foreach (Order o in orders)
                    {
                        Console.WriteLine( o.zapis);
                    }
                }
            }
            else
            {
                foreach (Order o in orders)
                {
                    Console.WriteLine(o.zapis);
                }
            }
        }

    }
}
