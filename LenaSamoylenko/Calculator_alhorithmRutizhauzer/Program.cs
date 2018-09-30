using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_alhorithmRutizhauzer
{
    class Program
    {

        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            bool beginCalculation = true;
            do
            {

                calc.assignLevel();
                if (calc.Count == 1) { break; }
                calc.exchangeInUserData();

            }
            while (beginCalculation);
            Console.WriteLine("Result");
            Console.WriteLine(calc.UserData);

            Console.ReadKey();
        }
    }
}
