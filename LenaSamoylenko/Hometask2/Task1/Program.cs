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
