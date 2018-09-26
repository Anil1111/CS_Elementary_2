using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Order
    {
        private string numberPayerCount;
        private string numderPayeeCount;
        public int transactionSum;

        public void inputData(string numberPayerCount1, string numderPayeeCount1, int transactionSum1, List<Order> list)
        {
            Order k = new Order();
            k.numberPayerCount = numberPayerCount1;
            k.numderPayeeCount = numderPayeeCount1;
            k.transactionSum = transactionSum1;
            list.Add(k);
        }

        public List<Order> orderBy(List<Order> list)
        {
            list = list.OrderBy(o => o.transactionSum).ToList();
            return list;
        }

        public void orderWithCondition(List<Order> list)
        {
            int userCondition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All positions");
            foreach (Order c in list)
            {
                if (c.transactionSum > userCondition)
                {
                    Console.Write($"{c.transactionSum}\t");
                    Console.Write($"{c.numberPayerCount}\t\t");
                    Console.Write($"{c.numderPayeeCount}");
                }
                else { Console.WriteLine("This count isn`t bigger than your condition"); }
                
            }
        }
    }



}
