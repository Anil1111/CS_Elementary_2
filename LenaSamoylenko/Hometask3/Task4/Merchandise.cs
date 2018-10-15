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
        public string MerchandiseName => merchandiseName;

        //ввод информации о товаре
        public Merchandise(string productName, double price, long barcode, string merchandiseName):base( productName, price, barcode)
        {
            AllProducts.Add(product);
            this.merchandiseName = merchandiseName;
        }

        public void AddProduct(Product product, List<Product> list)
        {
            list.Add(product);
        }
        //регистрация продажи

        //занести клиента в черный список

    }
}
