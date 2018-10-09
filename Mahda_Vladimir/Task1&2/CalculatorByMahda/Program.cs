using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorByMahda
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression;                              // переменная для входной строки
            int parenthesesQuantity = 0;                    // количество парных скобок
            
            Console.WriteLine("Welcome to string calculator");
            Console.WriteLine("Calculator supports '+', '-', '*', '/', '()' and only integer numbers");

            while (true)
            {
                string error = string.Empty;        // переменная для ошибок
                bool IsInputError = false;          // флаг ошибки ввода

                Console.WriteLine("Input your expression, please ('q' - exit)");
                expression = Console.ReadLine();
                if (expression == "q" || expression == "Q") break;
                //expression = "(2+2+(2-10/(5/1)*2)-2)-5";
                //expression = "25/5+(2*3-1/1*(2+6-5+10/3))";
                if (!StringCheck.IsExpressionTrue(expression, out error) || !StringCheck.IsParenthesesMatch(expression, out error, out parenthesesQuantity))
                {
                    Console.WriteLine(error);
                    IsInputError = true;
                }
                if (!IsInputError)
                {
                    Console.WriteLine($"Your expression -> {expression}");
                    while (parenthesesQuantity > 0)
                    {
                        expression = Calculate.ParenthesesOpen(expression);
                        parenthesesQuantity--;
                    }
                    Console.WriteLine("Result is : " + Calculate.CalculateExpression(expression));
                }
            }
        }
    }
}
