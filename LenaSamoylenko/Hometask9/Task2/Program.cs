using System;
using System.IO;

namespace Task2
{
    class Program
    {
        //Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте этот файл, прочитайте из него данные и выведете их на консоль

        static void Main(string[] args)
        {
            Console.WriteLine("Task2");

            AddData add = new AddData(FileMode.OpenOrCreate);
            ReadData read = new ReadData(FileMode.Open);

            Console.ReadKey();
        }
    }
}
