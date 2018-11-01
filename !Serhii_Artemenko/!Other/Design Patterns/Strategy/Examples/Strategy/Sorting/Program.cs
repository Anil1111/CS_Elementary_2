using Sorting.Strategy;
using Sorting.Strategy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 5, 4, 7 };

            Context context = new Context(new InsertionSort());
            context.Print(arr);
            Console.WriteLine();
            context.Sort(ref arr);
            context.Print(arr);

            Console.ReadLine();
        }
    }
}
