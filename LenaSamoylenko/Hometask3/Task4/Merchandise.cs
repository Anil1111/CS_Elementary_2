using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Merchandise : Product
    {
        private string merchandiseName;
        private double saleSum;
        public string MerchandiseName => merchandiseName;
        public double SaleSum => saleSum;
        struct order
        {
            public string klientName;
            public double saleSum;
            public string merchandiseName;
            public int productCount;
            public string productName;
        }

        private List<order> allSales = new List<order>();
        //ввод информации о товаре
        public Merchandise(int productCount, string productName, double price, long barcode, string merchandiseName, InternetStore store) : base(store.StoreName)
        {
            base.productCount = productCount;
            base.productName = productName;
            this.price = price;
            this.barcode = barcode;
            this.merchandiseName = merchandiseName;
        }


        //добавить определенного клиента в черный список
        private void AddClientToBlackList(Klient klient, InternetStore store)
        {
            (store.BlackList).Add(klient.KlientName);
        }



        //не могу добавить в список продаж
        public void FromOrderToSale(InternetStore store)
        {

            var localklient = store.allOrders[0];
            bool belongToBlackList = blackList.Exists(e => e.Equals(localklient.KlientName));

            {
                if (belongToBlackList)
                { Console.WriteLine("You could`t add the order"); }
                else
                {
                    //поиск цены по списку продуктов используя название 
                    var localVar = (store.AllProducts).Where(i => i.ProductName == localklient.ProductName);
                    var localVar1 = (localVar.Select(f => f.Price)).ToList();
                    //проверка на наличия суммы на счете, если нет, то в черный список
                    double localSum = (store.allOrders[0].ProductCount) * localVar1[0];
                    if (localklient.KlientBalance >= localSum)
                    {
                        //добавить в список продаж текущий заказ
                        order order1 = new order();
                        order1.klientName = localklient.KlientName;
                        order1.merchandiseName = merchandiseName;
                        order1.productCount = localklient.ProductCount;
                        order1.productName = localklient.ProductName;
                        order1.saleSum = localSum;
                        allSales.Add(order1);
                        localklient.KlientBalance = localklient.KlientBalance - localSum;
                        (store.allOrders).RemoveAt(0);
                    }
                    else
                    {
                        AddClientToBlackList(localklient, store);
                        Console.WriteLine("You are at black-list");
                    }
                }
            }
        }



    }
}

