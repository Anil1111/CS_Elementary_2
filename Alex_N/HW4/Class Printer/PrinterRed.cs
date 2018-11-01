using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Printer
{
    class PrinterRed : Printer
    {
        public void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Вы ввели:{text}");
        }
    }
}
