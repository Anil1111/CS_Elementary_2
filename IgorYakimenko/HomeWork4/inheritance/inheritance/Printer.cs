using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Printer
    {
        public void Print(string value)
        {
            Console.Write(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
