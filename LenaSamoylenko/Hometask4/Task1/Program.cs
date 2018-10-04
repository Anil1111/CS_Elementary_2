using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //примечание - создается типы объектов в массиве все-равно эземпляры класса Printer, PrinterYellow, PrinterBrown
            //влияет на характер ссылки
            Printer[] printSomeValue = new Printer[3];
            printSomeValue[0] = new Printer("Hello there");
            printSomeValue[1] = new PrinterYellow("Glad to see you");
            printSomeValue[2] = new PrinterDarkRed("Have a nice day");
            foreach (Printer p in printSomeValue)
            {
                p.Print(p.Text);
            }
            
            Console.WriteLine(new string('-', 32));

            PrinterYellow downCastValue1 = (PrinterYellow)printSomeValue[1];
            downCastValue1.Print(downCastValue1.Text);
            PrinterDarkRed downCastValue2 = (PrinterDarkRed)printSomeValue[2];
            downCastValue2.Print(downCastValue2.Text);
            Console.ReadKey();

        }
    }
}
