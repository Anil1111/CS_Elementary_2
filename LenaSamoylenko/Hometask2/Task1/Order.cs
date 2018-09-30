using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Order
    {
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


    }



}
