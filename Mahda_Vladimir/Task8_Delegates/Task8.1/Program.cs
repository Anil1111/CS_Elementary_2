using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента
//и возвращает среднее арифметическое этих аргументов.

namespace Task8._1
{
    public delegate int DelegateIntAverage(int number1, int number2, int number3);

    class Program
    {
        static void Main(string[] args)
        {
            DelegateIntAverage myDelegate = delegate (int number1, int number2, int number3) { return (number1 + number2 + number3) / 3; };
            Console.WriteLine($"Average: {myDelegate(3, 6, 12)}" );
            Console.ReadKey();
        }
    }
}
