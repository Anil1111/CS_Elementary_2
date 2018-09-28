using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        public static char[] ToParse(string virogenie)
        {
            char[] parsed = new char [virogenie.Length];
            parsed = virogenie.ToCharArray();
            return parsed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");
            string virojenie = Console.ReadLine();

            while(true)
            {
                int result;


            }
        }
    }
}
