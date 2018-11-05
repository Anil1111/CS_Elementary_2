using System;

namespace Task1
{
    public delegate double myDelegate(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! put a, b and c using Enter for division");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            myDelegate myDelegate = new myDelegate((int x, int y, int z) =>
            {
                
                double result = (double)(x+y+z)/3;
                return result;
            });

            Console.WriteLine("Result is");
            Console.WriteLine(myDelegate.Invoke(a, b, c));
            Console.ReadKey();
        }
    }
}
