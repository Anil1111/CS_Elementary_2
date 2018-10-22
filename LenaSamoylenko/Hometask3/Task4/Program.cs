using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetStore Market1 = new InternetStore("Market1");
            Merchandise merch1 = new Merchandise(23, "Coffee", 58.00, 56784904, "Masha", Market1);
            Market1.AddProduct(merch1);
            Merchandise merch2 = new Merchandise(10, "Tea", 29.99, 98564901, "Masha", Market1);
            Market1.AddProduct(merch2);
            Klient klient1 = new Klient("Ivan Petrovich", 120, Market1);
            klient1.AddOrder(Market1);
            merch1.FromOrderToSale(Market1);
            klient1.AddOrder(Market1);
            merch1.FromOrderToSale(Market1);
            Console.ReadKey();

        }
    }
}
