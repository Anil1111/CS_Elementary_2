using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    public class Printer
    {
        virtual public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"This is {value}");
        }
    }
}
