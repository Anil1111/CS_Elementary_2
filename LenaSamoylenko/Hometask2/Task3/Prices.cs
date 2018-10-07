using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Prices
    {
        List<Price> productsPrices;
        public Prices()
        {
            productsPrices = new List<Price>();
        }

        public void addProduct(Price price)
        {
            productsPrices.Add(price);
        }

        private void Show(string productName, string marketName, double productCost)
        {
            Console.WriteLine("productName:{0} marketName:{1} productCost:{2}", productName, marketName, productCost);
        }

        public void Print()
        {
            foreach (Price price in productsPrices)
            {
                Show(price.MarketName, price.ProductName, price.ProductCost);
            }
        }

        private void Print(List<Price> prices, string message)
        {
            Console.WriteLine(message);
            foreach (Price price in prices)
            {
                Show(price.MarketName, price.ProductName, price.ProductCost);
            }
        }

        public void nameOrder()
        {
            List<Price> tempList = new List<Price>();
            tempList = productsPrices.OrderBy(x => x.ProductName).ToList();
            Print(tempList, "All products with alphabetical order in products name");
        }
        public void userConditionOrder()
        {
            Console.WriteLine("Put your type of product");
            
            string productType =Console.ReadLine();
            foreach (Price price in productsPrices)
            {
                if (price.ProductName == productType)
                { Show(price.ProductName, price.MarketName, price.ProductCost); }
            }
        }
    }
}
