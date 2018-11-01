using System;

// Статический конструктор.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass notStaticClass = new NotStaticClass();
            NotStaticClass notStaticClass2 = new NotStaticClass();

            Console.WriteLine(NotStaticClass.ReadonlyField);

            // Delay.
            Console.ReadKey();
        }
    }
}
