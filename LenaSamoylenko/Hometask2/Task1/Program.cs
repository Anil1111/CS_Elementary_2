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
<<<<<<< HEAD
            Console.ReadKey();
            Order or = new Order();
            List<Order> orderList1 = new List<Order>();
            //
            or.inputData("1237-6789-8907", "7689-9067-6789", 890, orderList1);
            or.inputData("7689-9067-6789", "1237-6789-8907", 788, orderList1);
            //
            orderList1 = or.orderBy(orderList1);
            foreach (Order y in orderList1)
            { Console.WriteLine(y.transactionSum); }
            //
            Console.WriteLine("Put your condition");
            or.orderWithCondition(orderList1);
            Console.ReadKey();
        }


    }



}
=======
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




>>>>>>> d97b4f3d2c90536bc82b1e9b6b94c094d92be9ef
