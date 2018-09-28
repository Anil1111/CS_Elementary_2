using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class OrderTranzactionSumSort
    {
        public static void OrderSortMaxToMin(ref Order[] orderArray)
        {
            List<Order> sortedArray = orderArray.ToList().OrderBy(x => x.TranzactionSum).ToList();
            sortedArray.Reverse();
            orderArray = sortedArray.ToArray();
            Console.WriteLine("Array was sorted by tranzaction sum\n");

        }
    }
}
