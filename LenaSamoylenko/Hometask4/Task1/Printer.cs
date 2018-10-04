using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Printer
    {
        private string text;
        public string Text => text;
        public Printer(string text)
        {
            this.text = text;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
    }


    class PrinterYellow : Printer
    {
        public string identificatorPrintedYellow;
        public PrinterYellow(string text) : base(text) { }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
        }


    }

    class PrinterDarkRed : Printer
    {
        private string identificatorPrinterDarkRed;
        public PrinterDarkRed(string text) : base(text) { }
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(value);
        }

    }

}
