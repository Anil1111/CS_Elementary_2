using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutishauser
{
    abstract class Algoritm
    {
        protected static double AfterAlgoritm(string input)
        {
            List<char> afterPars = ToParsString(input);
            double result = Calculate( afterPars);
            return result;
        }

        private static double Calculate( List<char> input)
        {
            double result = 0;
            bool while1 = true;
            while (while1)
            {
                double peremenayaMax1 = 0;
                int indexMax1 = 0;
                double peremenayaMax2 = 0;
                int indexMax2 = 0;
                char operant = ' ';
                int max = 0;
                int[] levels = Leveling(input);

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == '(' || input[i] == ')')
                    {
                        continue;
                    }
                    if (levels[i] > max)
                    {
                        max = levels[i];
                        peremenayaMax1 = double.Parse(input[i].ToString());
                        indexMax1 = i;
                    }
                    else if (levels[i] == max)
                    {
                        peremenayaMax2 = double.Parse(input[i].ToString());
                        operant = input[i - 1];
                        indexMax2 = i;

                    }
                }

                switch (operant)
                {
                    case '+':
                        result += peremenayaMax1 + peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        char ch = char.Parse(result.ToString());
                        input.Insert(indexMax1 - 1, ch);
                        break;
                    case '-':
                        result += peremenayaMax1 - peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        char ch1 = char.Parse(result.ToString());
                        input.Insert(indexMax1 - 1, ch1);
                        break;

                    case '*':
                        result += peremenayaMax1 * peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        char ch2 = char.Parse(result.ToString());
                        input.Insert(indexMax1 - 1, ch2);
                        break;

                    case '/':
                        result += peremenayaMax1 / peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        char ch3 = char.Parse(result.ToString());
                        input.Insert(indexMax1 - 1, ch3);
                        break;
                }

                if (input.Count < 2)
                {
                    while1 = false;
                }
            }
            return result;
        }

        private static int[] Leveling(List<char> input)
        {
            int numberLevel = 0;
            int[] levels = new int[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                if (IsNumber(input[i]))
                {
                    numberLevel += 1;
                    levels[i] = numberLevel;
                }
                else if (IsOperation(input[i]))
                {
                    numberLevel -= 1;
                    levels[i] = numberLevel;
                }
                else
                {
                    Console.WriteLine("В выражении не допустимый символ!");
                }
            }

            return levels;
        }

        private static List<char> ToParsString(string input)
        {
            List<char> afterPars = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                afterPars.Add(input[i]);
            }

            return afterPars;
        }

        private static bool IsNumber(char c)
        {
            if ("(0123456789".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }

        private static bool IsOperation(char c)
        {
            if ("+-*/)".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }
    }
}
