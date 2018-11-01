using System;

// Константы.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass notStaticClass = new NotStaticClass();

            Console.WriteLine("e = {0}", NotStaticClass.e);

            // Delay.
            Console.ReadKey();
        }
    }
}
