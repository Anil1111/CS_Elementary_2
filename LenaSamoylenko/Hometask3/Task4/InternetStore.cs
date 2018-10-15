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
        List<Product> AllProducts=new List<Product>();
        List<Merchandise> AllSales = new List<Merchandise>();
        List<object> AllOrders = new List<object>();
        List<string> BlackList = new List<string>();
        public string StoreName => storeName;
        public InternetStore() { }
        public InternetStore(string storeName)
        {
            this.storeName = storeName;
        }

       
        public void RegistrationSale(Merchandise merchandise)
        {
            AllSales.Add(merchandise);
        }
        public void AddClientToBlackList(Klient klient)
        {
            BlackList.Add(klient.KlientName);
        }
        public void AddOrder(Klient klient, Product product)
        {
            bool belongToBlackList = BlackList.Exists(e=>e.Equals(klient.KlientName));
            if (belongToBlackList)
            { Console.WriteLine("You could`t add the order"); }
            AllOrders.Add($"klient"+ "product");
            klient.KlientCount = -product.Price;
        }
    }
}
