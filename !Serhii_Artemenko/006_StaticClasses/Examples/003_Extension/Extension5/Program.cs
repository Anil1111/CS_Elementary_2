using System;

// Расширяющие методы. (Extension methods)

// Использование ref и out аргументов. (Аргумент расширения не может быть ни ref ни out)

namespace Extension
{
    static class ExtensionClass
    {
        public static void Add(this ref int summand1, ref int summand2, out int sum)
        {
            summand2 = 5;
            sum = summand1 + summand2;
            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
        }
    }

    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum = 0;

            summand1.Add(ref summand2, out sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
