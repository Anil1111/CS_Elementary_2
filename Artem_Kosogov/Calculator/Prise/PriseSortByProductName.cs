using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class PriseSortByProductName
    {
        public static void SortProductByName(ref Prise[] priseArray)
        {
            List<Prise> tempList = priseArray.ToList().OrderBy(x => x.ProductName).ToList();
            priseArray = tempList.ToArray();
            Console.WriteLine("Array of products was sorted by product name");
        }
    }
}
