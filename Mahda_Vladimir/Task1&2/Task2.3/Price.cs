using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    public class Price
    {
        string priceTitle;
        string shopTitle;
        double productPrice;

        public string PriceTitle { get => priceTitle; }
        public string ShopTitle { get => shopTitle; }
        public double ProductPrice { get => productPrice; }

        public void Initializer(string priceTitle, string shopTitle, double productPrice)
        {
            this.priceTitle = priceTitle;
            this.shopTitle = shopTitle;
            this.productPrice = productPrice;
        }

        public Price(string priceTitle, string shopTitle, double productPrice)
        {
            Initializer(priceTitle, shopTitle, productPrice);
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Product: {PriceTitle,0 - 15}| Shop: {ShopTitle,0 - 10}| Price: {ProductPrice}");
        }
    }
}
