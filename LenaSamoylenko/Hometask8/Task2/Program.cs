using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is task 2");
            LoadBook loadBook = new LoadBook();
            FindAndReplaceManager.FindNext(loadBook);
            Console.ReadKey();

        }
    }
}
