using System;

namespace Task2
{
    public delegate double arithmeticOperation(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello! put x and y using Enter for division");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            arithmeticOperation Add = new arithmeticOperation((double var1, double var2) => { return (var1 + var2); });
            arithmeticOperation Sub = new arithmeticOperation((double var1, double var2) => { return (var1 - var2); });
            arithmeticOperation Mul = new arithmeticOperation((double var1, double var2) => { return (var1 * var2); });
            arithmeticOperation Div = new arithmeticOperation((double var1, double var2) =>
            {
                double result = 0;
                if (var2 == 0)
                {
                    Console.WriteLine("Error");
                    throw new ThisException("You couldn't use zero like divisor");
                }
                else
                { result = var1 / var2; }
                return result;
            }
            );

            Console.WriteLine("Result +:\t" + Add.Invoke(x, y));
            Console.WriteLine("Result -:\t" + Sub.Invoke(x, y));
            Console.WriteLine("Result *:\t" + Mul.Invoke(x, y));
            Console.WriteLine("Result /:\t" + Div.Invoke(x, y));
            Console.ReadKey();

        }




    }

}
