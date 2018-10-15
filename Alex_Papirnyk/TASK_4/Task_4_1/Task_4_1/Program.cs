using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "TESTER";
            string tip = "Приведение к типу";
            Printer p1 = new Printer();
            p1.Print(str);
            Show s1 = new Show();
            s1.Print(str);
            Printonator print1 = new Printonator();
            print1.Print(str);
            p1 = (Printonator)print1;
            p1.Print(tip);
            p1 = (Show)s1;
            p1.Print(tip);

            Console.ReadLine();
        }
    }
}
