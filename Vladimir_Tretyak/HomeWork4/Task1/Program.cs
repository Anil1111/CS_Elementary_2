using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4Task1
{
    class Printer
    {
        public virtual void Print(string text)
        {          
            Console.WriteLine(text);
        }
    }
    class Show : Printer
    {
        public override void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(text);          
        }
    }
    class newShow : Printer
    {
        public override void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(text);          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {         
            Printer a = new Printer();
            a.Print("Text Printer");
            Console.WriteLine();
            Show blue = new Show();
            blue.Print("Text Show");
            Console.WriteLine();
            newShow red = new newShow();
            red.Print("Text newShow");
            Console.ReadLine();         
        }
    }
}
