using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class Printonator:Printer
    {
        public override void Print(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
