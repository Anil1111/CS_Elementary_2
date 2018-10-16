using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Product : InternetStore
    {
        protected string productName;
        protected double price;
        protected long barcode;
        protected int productCount;
        public string ProductName => productName;
        public double Price => price;
        public long Barcode => barcode;
        public int ProductCount => productCount;
        protected Product(string storeName) : base(storeName) { }
    }
}
