using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Order
    {
<<<<<<< HEAD
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
=======
        private long numberPayerCount;
        private long numderPayeeCount;
        private double transactionSum;

        public long NumberPayerCount => numberPayerCount;
        public long NumderPayeeCount => numderPayeeCount;
        public double TransactionSum => transactionSum;

        public Order(long numberPayerCount, long numderPayeeCount, double transactionSum)
        {
            this.numberPayerCount = numberPayerCount;
            this.numderPayeeCount = numderPayeeCount;
            this.transactionSum = transactionSum;
        }
    }
    public class Orders
    {
        List<Order> orders;
        public Orders()
        { orders = new List<Order>(); }

        public void InputUserData(Order order)
        {
            orders.Add(order);
        }
        /// <summary>
        /// Печать одного заказа
        /// </summary>
        /// <param name="oneOrder">тип заказа</param>
        private void Show(Order oneOrder)
        { Console.WriteLine("{0} => {1} => {2}", oneOrder.NumberPayerCount, oneOrder.NumderPayeeCount, oneOrder.TransactionSum); }
        /// <summary>
        /// Печать всех заказов из указанного листа
        /// </summary>
        /// <param name="orders">исходные данные с указанного листа (сортированного или нет)</param>
        public void Print()
        {
            foreach (var oneOrder in orders)
            { Show(oneOrder); }
        }
        private void Print(List<Order> userList)
        {
            foreach (var oneOrder in userList)
            { Show(oneOrder); }
        }
        /// <summary>
        /// Печать отсортированного списка
        /// </summary>
        /// <param name="IsSorted"> переменная нужно ли сортировать</param>
        public void Print(bool IsSorted)
        {
            if (IsSorted)
            {
                List<Order> tempOrder;
                tempOrder = orders.OrderByDescending(x => x.TransactionSum).ToList();
                Print(tempOrder);
            }
        }

        public void Print(double userAmount)
        {
            foreach (Order oneOrder in orders)
            {
                if (userAmount <= oneOrder.TransactionSum)
                { Show(oneOrder); }
            }

        }


>>>>>>> d97b4f3d2c90536bc82b1e9b6b94c094d92be9ef
    }



}
