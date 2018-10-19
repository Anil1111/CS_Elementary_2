using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    class Klient
    {
        private string klientName;
        private double klientBalance;
        private string productName;
        private int productCount;
        public string KlientName => klientName;


        public string ProductName => productName;
        public int ProductCount => productCount;

        public double KlientBalance { get { return klientBalance; } set { klientBalance = value; } }

        public Klient(string klientName, double klientBalance, InternetStore store)
        {
            this.klientName = klientName;
            this.KlientBalance = klientBalance;
            store.PrintProductList();
        }
        public void AddOrder(InternetStore store)
        {
            Console.WriteLine("Введите номер товарa");
            int productType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество единиц");
            int pCount = Convert.ToInt32(Console.ReadLine());
            if (productType <= (store.AllProducts).Count && store.AllProducts[productType - 1].ProductCount >= pCount)
            {
                productName = store.AllProducts[productType - 1].ProductName;
                productCount = pCount;
                (store.allOrders).Add(this);
            }
            else
            {
                Console.WriteLine("Some error");
            }

            // string KlientName; string productName; int productCount;
        }
    }
}

