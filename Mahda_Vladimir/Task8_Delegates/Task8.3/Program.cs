using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и 
//возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами 
//в массиве. Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.

namespace Task8._3
{
    public delegate int RandomNumber();
    public delegate double Average(RandomNumber[] arrayRandomNumbers);

    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            RandomNumber randomNumber = delegate ()
            {
                
                int result = number.Next(1, 101);
                Console.WriteLine($"random number: {result}");
                return result;
            };

            Average myDelegate = delegate (RandomNumber[] arrayNumber)
            {
                int sum = 0;
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    sum += arrayNumber[i].Invoke();
                }
                return (double)sum / arrayNumber.Length;
            };

            RandomNumber[] array = new RandomNumber[] { randomNumber, randomNumber, randomNumber, randomNumber};

            Console.WriteLine($"Average: {myDelegate.Invoke(array)} ");

            Console.ReadKey();
        }
    }
}