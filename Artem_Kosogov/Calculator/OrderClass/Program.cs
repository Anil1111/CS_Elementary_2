using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            //Order[] array = OrderInput.GetInputOrderData();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i].ToString());
            //}
            Order[] array = new Order[] { new Order(12345678, 23456789, 100), new Order(12356789, 12345678, 300), new Order(22222222, 34343434, 200) };
            Console.WriteLine();
            OrderTranzactionSumSort.OrderSortMaxToMin(ref array);
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine();
            OrderTranzactionSumConditionPrint.PrintOrdersWithSumCondition(array);
            Console.ReadKey();
        }
    }
}