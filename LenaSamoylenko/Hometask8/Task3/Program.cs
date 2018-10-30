using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 9, 8, 7, 6, 5 };
            var myArray = ar.SortArray(ar);
            foreach (int k in myArray)
            { Console.WriteLine(k); }
            Console.ReadKey();
        }
    }

    public static class Extention
    {
        public static int[] SortArray(this Array array, int[] a)
        {
            int[] result = null;
            result =a.OrderBy(x => x).ToArray();
            return result;
        }
    }


}
