using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConnectingDB c1 = null;
            UsingDB usingDB = new UsingDB(c1);
            usingDB.SelectAllFromCity();
            Console.ReadKey();
        }
    }
}
