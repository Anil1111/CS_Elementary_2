using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Orders
    {
        List<Order> orders;
        List<Order> tempOrders;

        public Orders()
        {
            orders = new List<Order>();
            tempOrders = new List<Order>();
        }

        /// <summary>
        /// добавление заказа в список заказов
        /// </summary>
        /// <param name="order"></param>
        public void InputUsersDataInListOrders(Order order)
        {
            orders.Add(order);
        }
        /// <summary>
        /// Печать всех заказов
        /// </summary>
        public void PrintAll()
        {
            foreach (var order in orders)
            {
                order.PrintOrder();
            }
        }
        /// <summary>
        /// Печать сортированного списка заказов
        /// </summary>
        public void PrintSortedOrdersByDescendingAmount()
        {
            tempOrders = orders.OrderByDescending(x => x.TransferredAmount).ToList();
            if (tempOrders.Count > 0)
            {
                foreach (var order in tempOrders)
                {
                    order.PrintOrder();
                }
            }
            else //???
            {
                Console.WriteLine("List is empty");
            }
        }

        /// <summary>
        /// печать заказов, перечисляемая сумма которых не меньше суммы, 
        /// введенной пользователем.
        /// </summary>
        /// <param name="userAmount">не меньше какой суммы?</param>
        public void PrintOrdersMoreUserAmount(double userAmount)
        {
            bool isEmpty = false;
            foreach (var order in orders)
            {
                if (order.TransferredAmount >= userAmount)
                {
                    order.PrintOrder();
                    isEmpty = true;
                }
            }
            if(!isEmpty)
            {
                Console.WriteLine("No orders matching your request");
            }
        }
    }
}
