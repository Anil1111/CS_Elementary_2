using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Point : IComparable
    {
        public int x;
        public int y;

        public int CompareTo(object obj)
        {
            var point = (Point)obj;

            var thisDst = Math.Sqrt(x * x + y * y);
            var thatDst = Math.Sqrt(point.x * point.x + point.y * point.y);

            //if (thisDst < thatDst) return -1;
            //else if (thisDst == thatDst) return 0;
            //else return 1;

            return thisDst.CompareTo(thatDst);

        }
    }

    public static class ArrayExtensions
    {
        //public static void Swap(this Array array, int i, int j)
        //{
        //    object temporary = array.GetValue(i);
        //    array.SetValue(array.GetValue(i), j);
        //    array.SetValue(temporary, j);
        //}

        public static void BubbleSort(this Array array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var element1 = (IComparable)array.GetValue(j);
                    var element0 = (IComparable)array.GetValue(j - 1);

                    if (element1.CompareTo(element0) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[] { "B", "A", "C" };
            strings.BubbleSort();

            var ints = new int[] { 1, 3, 2 };
            ints.BubbleSort();

            var doubleArray = new double[] { 3, 2, 1 };
            doubleArray.BubbleSort();

            var pointArray = new Point[]
                {
                    new Point { x = 3, y = 3},
                    new Point { x = 1, y = 1},
                    new Point { x = 2, y = 2}
                };
            pointArray.BubbleSort();

            Console.ReadLine();
        }

       
    }
}
