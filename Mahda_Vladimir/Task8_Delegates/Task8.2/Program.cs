using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создайте четыре лямбда оператора для выполнения арифметических действий: 
//(Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
//Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
//Лямбда оператор деления должен делать проверку деления на ноль. 
//Написать программу, которая будет выполнять арифметические действия указанные пользователем.

namespace Task8._2
{
    public delegate double MathAction(double number1, double number2);

    class Program
    {
        // Ввод числа
        public static double InputDoubleNumber(string message)
        {
            double result = 0;
            do
            {
                Console.Write($"Input {message}: ");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Input error, try one more time");
                }
            } while (true);
        }

            static void Main(string[] args)
        {
            MathAction Add = (x, y) => { return x + y; };
            MathAction Sub = (x, y) => { return x - y; };
            MathAction Mul = (x, y) => { return x * y; };
            MathAction Div = (x, y) =>
            {
                if (y != 0)
                {
                    return x / y;
                }
                else
                {
                    Console.WriteLine("Mistake! Division by zero is not allowed");
                    return 0;
                }
            };

            bool isContinue = true;
            do
            {
                double number1 = InputDoubleNumber("number1");
                double number2 = InputDoubleNumber("number2");
                Console.Write("Select your action: '+', '-', '*', '/' or 'q' to exit: ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.KeyChar)
                {
                    case 'q':
                        isContinue = false;
                        break;
                    case '+':
                        Console.WriteLine($"{number1} + {number2} = {Add(number1, number2)}");
                        break;
                    case '-':
                        Console.WriteLine($"{number1} - {number2} = {Sub(number1, number2)}");
                        break;
                    case '*':
                        Console.WriteLine($"{number1} * {number2} = {Mul(number1, number2)}");
                        break;
                    case '/':
                        Console.WriteLine($"{number1} / {number2} = {Div(number1, number2)}");
                        break;
                    default:
                        Console.WriteLine("Wrong action");
                        break;
                }
                Console.WriteLine();
            } while (isContinue);
        }
    }
}
