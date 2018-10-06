﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class Orders
    {
        List<Order> orders;
        List<Order> temp;

        public Orders()
        {
            orders = new List<Order>();
            temp = new List<Order>();
        }

        /// <summary>
        /// Добавление новых заказов в список
        /// </summary>
        /// <param name="order">Заказ</param>
        public void InputUserData(Order order)
        {
            orders.Add(order);
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        public void Print()
        {
            foreach (var order in orders)
            {
                Show(order);
            }
        }

        /// <summary>
        /// Упорядочить по убыванию перечисляемой суммы
        /// </summary>
        /// <param name="isSorted">Сортировать ли?</param>
        public void Print(bool isSorted)
        {
            if (isSorted)
            {
                temp = orders.OrderByDescending(x => x.Amount).ToList();
                foreach (var order in temp)
                {
                    Show(order);
                }
            }

        }

        /// <summary>
        /// Вывод информации о тех плательщиках, сумма перечислений которых меньше
        /// </summary>
        /// <param name="userAmount">Сумма</param>
        public void Print(double userAmount)
        {
            foreach (var order in orders)
            {
                if (userAmount <= order.Amount)
                {
                    Show(order);
                }
            }
        }
        private void Show(Order order)
        {
            Console.WriteLine($"{order.PayerAccount}->{order.BeneficiaryAccount}->{order.Amount}");
        }




    }
}
