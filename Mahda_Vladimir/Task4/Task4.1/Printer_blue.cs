using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    public class Printer_blue : Printer
    {
        override public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"This is {value}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    
}
