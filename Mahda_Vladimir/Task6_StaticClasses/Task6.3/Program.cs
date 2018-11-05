using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать расширяющий метод для целочисленного массива, 
//который сортирует элементы массива по возрастанию.

namespace Task6._3
{
    public static class ArraySort
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
            return array;
        }

        public static void ShowArray(int[] array, string message)
        {
            Console.WriteLine(message);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 25));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 5, 7, 4, 1, 9, 3, 2, 6 };
            ArraySort.ShowArray(array, "Array before sorting:");
            ArraySort.ShowArray(ArraySort.InsertionSort(array), "Array after sorting:");
            Console.ReadKey();
        }
    }
}
