using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3
{
    public class Prices
    {
        List<Price> prices;
        List<Price> tempPrices;

        public Prices()
        {
            prices = new List<Price>();
            tempPrices = new List<Price>();
        }

        public void AddDataToList (Price price)
        {
            prices.Add(price);
        }

        public void PrintAllProducts()
        {
            foreach (var price in prices)
            {
                price.PrintPrice();
            }
        }

        public void PrintPricesSortedByAlphabet()
        {
            Console.WriteLine("Sorted by alphabed");
            tempPrices = prices.OrderBy(x => x.PriceTitle).ToList();
            foreach (var price in tempPrices)
            {
                price.PrintPrice();
            }
        }

        public void PrintUsersPrices()
        {
            Console.Write($"Input price title: ");
            string usersTitle = Console.ReadLine();
            bool havePricesWithUsersTitles = false;
            foreach (var price in prices)
            {
                if(price.PriceTitle == usersTitle)
                {
                    price.PrintPrice();
                    havePricesWithUsersTitles = true;
                }
            }
            if (!havePricesWithUsersTitles)
            {
                Console.WriteLine("No prices matching your request");
            }
        }

    }


   
}
