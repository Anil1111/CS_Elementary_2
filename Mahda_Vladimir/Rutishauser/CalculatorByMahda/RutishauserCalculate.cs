using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorByMahda
{
    public class RutishauserCalculate
    {
        public static void ShowExpressionList(string message, IList list)
        {
            Console.WriteLine(message);
            foreach (var item in list)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine();
        }
        //Парсим в список и считаем
        public static void ParseToList(string expression)
        {
            List<string> listStringExpression = new List<string>();
            List<int> listLevels = new List<int>();
            bool flagNumber = true;                         // флаг для обозначения цифры
            string stringNumber = string.Empty;             // переменная для числа
            for (int j = 0; j < expression.Length; j++)
            {
                // если ch - цифра, то добавляем ее к стринговой _number
                if (expression[j] >= '0' && expression[j] <= '9')
                {
                    stringNumber += expression[j].ToString();
                    // флаг, который сообщает, что была цифра
                    flagNumber = true;
                    // если дошли до последнего символа, то сразу парсим число
                    if (j == expression.Length - 1) listStringExpression.Add(stringNumber);
                }
                // если ch - операция
                else if (expression[j] == '+' || expression[j] == '-' || expression[j] == '*' || expression[j] == '/' || expression[j] == '(' || expression[j] == ')')
                {
                    // если выражение начинается с минуса или после открывающей скобки стоит отрицательное значение, то парсим этот 'минус' в число
                    if (expression[j] == '-' && (j == 0 || (expression[j - 1] == '(')))
                    {
                        stringNumber = expression[j].ToString();
                        flagNumber = true;
                    }
                    else
                    {
                        // парсим и добавляем предыдущее число в список
                        if (stringNumber != String.Empty) listStringExpression.Add(stringNumber);
                        //флаг сброса числа
                        flagNumber = false;
                        // парсим операцию в список
                        listStringExpression.Add(expression[j].ToString());
                    }
                }
                // обнуляем стринговую переменную для следующего числа
                if (!flagNumber) stringNumber = string.Empty;
            }

            do  //начало цикла расчета выражений в скобках
            {
                listLevels = CheckLevel(listStringExpression);  //расставляем уровни
                int maxLevel = FindMaxLevel(listLevels);        //находим макс уровень
                int firstMaxLevelPosition = FindFirstMaxPosition(listLevels, maxLevel); //находим позицию первого числа с макс уровнем
                int currentPosition = firstMaxLevelPosition;
                int operationPosition = firstMaxLevelPosition + 1;

                do  //выполняем приоритетные операции (* и /)
                {       //если операция приоритетна
                    if (IsHiPriority(listStringExpression[operationPosition]))
                    {   //выполняем ее
                        listStringExpression = CalculateExpr(listStringExpression, currentPosition);
                    }
                    else
                    {   //если не дошли до закрывающей скобки и число не последнее в строке, то переходим к следующему числу
                        if (listStringExpression[operationPosition] != ")" && currentPosition != listStringExpression.Count - 2)
                        {
                            currentPosition += 2;
                            operationPosition += 2;
                        }
                    }
                    //сработает только на строке без скобок!
                    if (currentPosition == listStringExpression.Count - 1) break;
                } while (listStringExpression[operationPosition] != ")");

                do  //выполняем не приоритетные операции (* и /)
                {
                    //если уже все посчитано и осталось лишь одно число
                    if (listStringExpression.Count == 1) break;
                    //если первая операция не закрывающая скобка, то
                    if (listStringExpression[firstMaxLevelPosition + 1] != ")")
                    {   //выполняем ее
                        listStringExpression = CalculateExpr(listStringExpression, firstMaxLevelPosition);
                    }
                    //сработает только на строке без скобок!
                    if (firstMaxLevelPosition == listStringExpression.Count - 1) break;
                } while (listStringExpression[firstMaxLevelPosition + 1] != ")");
                //Если max уровень > 1 (т.е. скобки были), то удаляем скобки
                if (FindMaxLevel(listLevels) > 1)
                {
                    Delete2Parentheses(listStringExpression, firstMaxLevelPosition);
                }
            } while (listStringExpression.Count != 1);
            ShowExpressionList("Result is : ", listStringExpression);

        }

        // выполняем расстановку уровней
        public static List<int> CheckLevel(List<string> expression)
        {
            List<int> levels = new List<int>(expression.Count);
            levels.Add(1);
            for (int i = 1; i < expression.Count; i++)
            {
                if (expression[i] == "+" || expression[i] == "-" || expression[i] == "*" || expression[i] == "/" || expression[i] == ")")
                {
                    levels.Add(levels[i - 1] - 1);
                }
                else
                {
                    levels.Add(levels[i - 1] + 1);
                }
            }
            return levels;
        }

        //находим максимальный уровень
        public static int FindMaxLevel(List<int> levels)
        {
            int max = 0;
            for (int i = 1; i < levels.Count; i++)
            {
                if (levels[i] > max)
                {
                    max = levels[i];
                }
            }
            return max;
        }

        //возвращаем список позиций элементов с максимальным уровнем
        public static List<int> FindMaxPositions(List<int> levels, int max)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < levels.Count; i++)
            {
                if (levels[i] == max)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        //возвращаем позицию первого элемента с максимальным уровнем
        public static int FindFirstMaxPosition(List<int> levels, int max)
        {
            int firstMaxPosition = 0;
            for (int i = 0; i < levels.Count; i++)
            {
                if (levels[i] == max)
                {
                    firstMaxPosition = i;
                    return firstMaxPosition;
                }
            }
            return firstMaxPosition;
        }

        /// <summary>
        /// вычисляем арифм. выражение в заданной позиции
        /// </summary>
        /// <param name="listExspression"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static List<string> CalculateExpr(List<string> listExspression, int position)
        {
            switch (listExspression[position + 1])
            {
                case "+":
                    listExspression[position] = Calculate.Addition(Int32.Parse(listExspression[position]), Int32.Parse(listExspression[position + 2])).ToString();
                    break;
                case "-":
                    listExspression[position] = Calculate.Subtraction(Int32.Parse(listExspression[position]), Int32.Parse(listExspression[position + 2])).ToString();
                    break;
                case "*":
                    listExspression[position] = Calculate.Multiplication(Int32.Parse(listExspression[position]), Int32.Parse(listExspression[position + 2])).ToString();
                    break;
                case "/":
                    listExspression[position] = Calculate.Division(Int32.Parse(listExspression[position]), Int32.Parse(listExspression[position + 2])).ToString();
                    break;
            }
            //удаляем операцию и число за ней
            Delete2Elements(listExspression, position);
            return listExspression;
        }

        public static List<string> CalculatePriorityExpr(List<string> listExspression, int position)
        {
            return listExspression;
        }

        //Удаляем два элемента в списке после указанной позиции (для удаления элементов после подсчета арифметической операции)
        public static void Delete2Elements(IList list, int position)
        {
            list.RemoveAt(position + 2);
            list.RemoveAt(position + 1);
        }

        //Удаляем два элемента в списке до и после указанной позиции (для удаления скобок)
        public static void Delete2Parentheses(IList list, int position)
        {
            list.RemoveAt(position + 1);
            list.RemoveAt(position - 1);

        }

        //проверяем операцию на приоритетность
        public static bool IsHiPriority(string operation)
        {
            if (operation == "*" || operation == "/") return true;
            return false;
        }

        //проверка, осталось ли одно число в скобках
        public static bool IsNumberInParentheses(List<string> expression, int position)
        {
            if (position == 0 || position == expression.Count) return false;
            if (expression[position - 1] == "(" && expression[position + 1] == ")") return true;
            return false;
        }
    }
}
