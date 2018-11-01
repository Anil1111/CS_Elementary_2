using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Printer
{
    class PrinterBlue : Printer
    {
        public void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Вы ввели:{text}");
        }
    }
}
