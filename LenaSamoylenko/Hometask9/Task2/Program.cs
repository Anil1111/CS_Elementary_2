using System;

namespace Task2
{
    class Program
    {
        //Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте этот файл, прочитайте из него данные и выведете их на консоль

        static void Main(string[] args)
        {
            Console.WriteLine("Task2");

            AddData add = new AddData();
            add.AddDataToFile();

            ReadData read = new ReadData();
            read.PrintConsole();
            Console.ReadKey();
        }
    }
}
