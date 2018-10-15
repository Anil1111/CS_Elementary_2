using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class InternetStore
    {
        private string storeName;
        private List<Merchandise> allProducts = new List<Merchandise>();

        public List<Klient> allOrders = new List<Klient>();
        protected List<string> blackList = new List<string>();
        public string StoreName => storeName;

        public List<Merchandise> AllProducts => allProducts;

        //internal List<order> AllSales { get; set; }
        internal List<string> BlackList { get; set; }
        public InternetStore(string storeName)
        {
            this.storeName = storeName;
        }

        public void PrintProductList()
        {
            int i = 1;
            foreach (Merchandise p in AllProducts)
            {
                Console.WriteLine("Товар номер {3} - Наименование: {0}; Цена: {1}; Количество на складе:{2}", ((Product)p).ProductName, ((Product)p).Price, ((Product)p).ProductCount, i);
                i++;
            }
        }

        public void AddProduct(Merchandise product)
        {
            AllProducts.Add(product);
        }


        //public void AddOrder(Klient klient, Product product)
        //{
        //    bool belongToBlackList = BlackList.Exists(e=>e.Equals(klient.KlientName));
        //    if (belongToBlackList)
        //    { Console.WriteLine("You could`t add the order"); }
        //    AllOrders.Add($"klient"+ "product");
        //    klient.KlientCount = -product.Price;
        //}
    }
}
