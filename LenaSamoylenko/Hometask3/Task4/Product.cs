using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Product: InternetStore
    {
        private string productName;
        private double price;
        private long barcode;

        public string ProductName => productName;
        public double Price => price;
        public long Barcode=> barcode;
        protected Product() { }
        protected Product(string productName, double price, long barcode)
        {
            this.productName = productName;
            this.price = price;
            this.barcode = barcode;
        }
    }
}
