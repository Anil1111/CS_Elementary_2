using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class DerivedClass : Printer
    {
        private string value;

        public DerivedClass(ConsoleColor color)
        {
            Print(value);
            Console.ForegroundColor = color;
            color = ConsoleColor.Gray;
        }

       
    }
}
