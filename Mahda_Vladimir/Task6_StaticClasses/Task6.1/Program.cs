using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать статический класс Calculator, с методами для выполнения основных арифметических 
//операций.Написать программу, которая выводит на экран основные арифметические операции.

namespace Task6._1
{
    public static class Calculator
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Division(double number1, double number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Division by zero is inpossible!");
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.5, num2 = 3.2, num0 = 0; ;
            Console.WriteLine($"{num1} + {num2} = {Calculator.Add(num1, num2), 0-7:N2}");
            Console.WriteLine($"{num1} - {num2} = {Calculator.Subtraction(num1, num2), 0-7:N2}");
            Console.WriteLine($"{num2} * {num1} = {Calculator.Multiplication(num2, num1),0 - 7:N2}");
            Console.WriteLine($"{num2} / {num0} = {Calculator.Division(num2, num0),0 - 7:N2}");
            Console.WriteLine($"{num1} / {num2} = {Calculator.Division(num1, num2),0 - 7:N2}");

            Console.ReadKey();
        }
    }
}
