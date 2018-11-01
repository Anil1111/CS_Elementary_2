using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Printer
{
    class PrinterGreen : Printer
    {
        public void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Вы ввели:{text}");
        }
    }
}
