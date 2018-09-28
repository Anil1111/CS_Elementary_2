using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //Prise[] array = PriseInput.GetPriseInput();
            Prise[] array = new Prise[] { new Prise("Tomato", "ATB", 30), new Prise("Cucumber", "Pyatoro4ka", 23), new Prise("Sausages delicate", "ATB", 18) };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine();
            PriseSortByProductName.SortProductByName(ref array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
            Console.WriteLine();
            PrisePrintUserProductName.PrintPriseUserProductName(array);
            Console.ReadKey();

        }
    }
}
