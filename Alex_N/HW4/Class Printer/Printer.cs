using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Printer
{
     class Printer
    {        
        public void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"Вы ввели: {text}");
        }
    }
}
