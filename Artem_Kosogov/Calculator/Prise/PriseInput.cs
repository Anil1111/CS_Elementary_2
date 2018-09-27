using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class PriseInput
    {
        public static Prise[] GetPriseInput()
        {
            Console.WriteLine("Please, enter number of products");
            int n = int.Parse(Console.ReadLine());
            Prise[] priseArray = new Prise[n];
            for (int i = 0; i < priseArray.Length; i++)
            {
                priseArray[i] = new Prise();
            }
            Console.WriteLine(@"Please enter information about product in this format: ""Product name, shop name, prise""");
            try
            {
                for (int i = 0; i < priseArray.Length; i++)
                {
                    string temp = Console.ReadLine();
                    string[] substrings = temp.Split(',');
                    priseArray[i].ProductName = substrings[0];
                    priseArray[i].ShopName = substrings[1];
                    priseArray[i].ProductPrise = int.Parse(substrings[2]);
                }
            }
            catch
            {
                Console.WriteLine("You entered the data in a wrong format");
            }
            return priseArray;
        }
    }
}
