using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClass
{
    class SortOrders
    {
        public IOrderedEnumerable<Order> SotrOrder(Order[] order_, double inputSum_)
        {
           var selectedorder = from t in order_ // определяем каждый объект из teams как t
                               where t.SummPayer >= inputSum_
                               orderby t.SummPayer descending  // упорядочиваем по убыванию
                                select t; // выбираем объект

            return selectedorder;
        }   
    }
}
