using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorByMahda
{
    class Calculate
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Division by zero");
                Console.ReadKey();
                System.Environment.Exit(0);
                return 0;
            }              
        }

        //вырезаем из выражения самое вложенное выражение в скобках
        public static string ParenthesesOpen(string inputExpression)
        {
            //Console.WriteLine("входящее выражение: " + inputExpression);
            string newExpression = String.Empty;                //новое выражение
            string parenthesesExpression = String.Empty;        //выражение в скобках

            int resultEnd = inputExpression.IndexOf(')');                   //находим позицию первой закрывающей скобки
            int resultStart = inputExpression.LastIndexOf('(', resultEnd);  //находим позицию открывающей скоки
            parenthesesExpression = inputExpression.Substring(resultStart + 1, resultEnd - resultStart - 1);        //копируем выражение в скобках в новую переменную
            newExpression = CalculateExpression(parenthesesExpression);     //вычисляем значение в скобках
            inputExpression = inputExpression.Replace('(' + parenthesesExpression + ')', newExpression); //заменяем выражение со скобками на результат вычислений 
            //Console.WriteLine("выражение в скобках: " + parenthesesExpression);
            //Console.WriteLine("вычис-ние в скобках: " + newExpression);
            //Console.WriteLine("получ-ный результат: " + inputExpression);
            return inputExpression;
        }

        //вычисляем строковое выражение
        public static string CalculateExpression(string expression)
        {
            List<int> listNumbers = new List<int>();        // список чисел
            List<string> listAction = new List<string>();   // список операций
            bool flagNumber = true;                         // флаг для обозначения цифры
            string stringNumber = string.Empty;             // переменная для числа

            listNumbers.Clear();
            listAction.Clear();
            for (int j = 0; j < expression.Length; j++)
            {
                // если ch - цифра, то добавляем ее к стринговой _number
                if (expression[j] >= '0' && expression[j] <= '9')
                {
                    stringNumber += expression[j].ToString();
                    // флаг, который сообщает, что была цифра
                    flagNumber = true;
                    // если дошли до последнего символа, то сразу парсим число
                    if (j == expression.Length - 1) listNumbers.Add(Parser.ParseNumber(stringNumber));
                }
                // если ch - операция
                else if (expression[j] == '+' || expression[j] == '-' || expression[j] == '*' || expression[j] == '/')
                {
                    // если выражение начинается с минуса или после вычисления выражения в скобках получилось отрицательное значение, то парсим этот 'минус' в число
                    if ((expression[j] == '-' && j == 0) || (expression[j] == '-' && (expression[j - 1] == ('+') || expression[j - 1] == ('-') || expression[j - 1] == ('*') || expression[j - 1] == ('/'))))
                    {
                        stringNumber = expression[j].ToString();
                        flagNumber = true;
                    }
                    else
                    {
                        // парсим и добавляем предыдущее число в список чисел
                        listNumbers.Add(Parser.ParseNumber(stringNumber));
                        //флаг сброса числа
                        flagNumber = false;
                        // парсим операцию в список операций
                        listAction.Add(expression[j].ToString());
                    }
                }
                // обнуляем стринговую переменную для следующего числа
                if (!flagNumber) stringNumber = string.Empty;
            }
            // первый проход - умножаем и делим
            int i = 0;
            while (i < listAction.Count)
            {
                if (listAction[i] == "*")
                {
                    listNumbers[i + 1] = Multiplication(listNumbers[i], listNumbers[i + 1]);
                    listNumbers.RemoveAt(i);
                    listAction.RemoveAt(i);
                }
                else if (listAction[i] == "/")
                {
                    listNumbers[i + 1] = Division(listNumbers[i], listNumbers[i + 1]);
                    listNumbers.RemoveAt(i);
                    listAction.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            // второй проход = складываем и вычитаем
            i = 0;
            while (i < listAction.Count)
            {
                if (listAction[i] == "+")
                {
                    listNumbers[i + 1] = Addition(listNumbers[i], listNumbers[i + 1]);
                    listNumbers.RemoveAt(i);
                    listAction.RemoveAt(i);
                }
                else
                {
                    listNumbers[i + 1] = Subtraction(listNumbers[i], listNumbers[i + 1]);
                    listNumbers.RemoveAt(i);
                    listAction.RemoveAt(i);
                }
            }
            return listNumbers[0].ToString();
        }
    }
}
