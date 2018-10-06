using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders orders = new Orders();
            Order order1 = new Order(numberPayerCount: 123767898907, numderPayeeCount: 768990676789, transactionSum: 890);
            orders.InputUserData(order1);
            Order order2 = new Order(768990676789, 123767898907, 788);
            orders.InputUserData(order2);
            Order order3 = new Order(789001676789, 123767898907, 370);
            orders.InputUserData(order3);
            Console.WriteLine("All orders");
            orders.Print();
            Console.WriteLine("All orders with sorting");
            orders.Print(true);
            Console.WriteLine("Put your condition for amount");
            int userCondition = Convert.ToInt32(Console.ReadLine());
            orders.Print(userCondition);
            Console.ReadKey();

        }
    }

}




