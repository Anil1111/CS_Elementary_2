using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator_LenaSamoylenko
{
    class Program
    {
        static void Main(string[] args)
        {

            //intitizlization
            List<int> numbers = new List<int>();
            List<char> operations = new List<char>();
            List<int> result = new List<int>();
            result.Add(0);
            Console.WriteLine("Hello! Put your basic data using 0-9 and +, -, *, /, ()");
            string basicData = Console.ReadLine();
            string[] leftBrackets = { };
            string[] rightBrackets = { };
            string[] firstOperation = { };

            do
            {

                numbers.Clear();
                operations.Clear();
                leftBrackets = basicData.Split('(');
                rightBrackets = basicData.Split(')');
                firstOperation = leftBrackets[leftBrackets.Length - 1].Split(')');

                if (leftBrackets.Length == firstOperation.Length || leftBrackets.Length == rightBrackets.Length)
                {
                    //нахождение чисел в выражении
                    Regex numbersInLine = new Regex(@"[0-9]+");
                    MatchCollection numMatchCollection = numbersInLine.Matches(firstOperation[0]);
                    foreach (Match match in numMatchCollection)
                    {
                        numbers.Add(Int32.Parse(match.Value));
                        match.NextMatch();
                    }
                    //нахождение знака операции
                    Regex operationInLine = new Regex(@"[+,-,*,/]");
                    MatchCollection operationMatchCollection = operationInLine.Matches(firstOperation[0]);
                    foreach (Match match in operationMatchCollection)
                    {
                        operations.Add(Char.Parse(match.Value));
                        match.NextMatch();
                    }

                    //подсчет приоритетных операций - '*' и '/'
                    int i = 0;
                    while (i <= operations.Count - 1)
                    {
                        if (operations[i] == '+' || operations[i] == '-') { i++; }
                        else if (operations[i] == '*' || operations[i] == '/')
                        {
                            workWithList(i, numbers, operations);
                        }
                        else { }
                    }

                    //подсчет операций "+" и "-"
                    int j = 0;
                    while (j <= operations.Count - 1)
                    {
                        if (operations[j] == '+' || operations[j] == '-')
                        {
                            workWithList(j, numbers, operations);
                        }
                        else { }

                    }
                    result.Add(numbers[0]);



                    //замена строки для повторной отработки 
                    basicData = basicData.Replace("(" + firstOperation[0] + ")", numbers[0].ToString());
                }
                else
                {
                    Console.WriteLine("Error in the numbers of brackets");
                    Console.ReadKey();
                    return;
                }

            }

            while (result[result.Count - 1] != result[(result.Count - 2)]);
            Console.WriteLine("Result is: {0}", result[result.Count - 1]);
            Console.ReadKey();


        }

        public static int operationType(char calcOperator, int x1, int x2)
        {
            int result;
            if (calcOperator == '-') return result = x1 - x2;
            else if (calcOperator == '+') return result = x1 + x2;
            else if (calcOperator == '*') return result = x1 * x2;
            else if (calcOperator == '/') return result = x1 / x2;
            else
            {
                Console.WriteLine("Error");
                return result = 0;
            }
        }

        public static void workWithList(int i, List<int> x1, List<char> x2)
        {
            x1[i + 1] = operationType(x2[i], x1[i], x1[i + 1]);
            x1.RemoveAt(i);
            x2.RemoveAt(i);
        }
    }
}





