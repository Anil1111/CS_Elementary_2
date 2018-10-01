using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Price
    {
        private string productName;
        private string marketName;
        private double productCost;

        public string ProductName => productName;
        public string MarketName => marketName;
        public double ProductCost => productCost;

        public Price(string productName, string marketName, double productCost)
        {
            this.productName = productName;
            this.marketName = marketName;
            this.productCost = productCost;
        }
    }
}
