using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        //1 - Создайте класс Printer. В теле класса создайте метод void Print(string value), 
        //    который выводит на экран значение аргумента. Реализуйте возможность того, чтобы в случае 
        //    наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, строки, 
        //    переданные в качестве аргументов методов, выводились разными цветами. Обязательно используйте приведение типов.

        static void Main(string[] args)
        {
            Printer pr = new Printer();
            pr.Print("Test1");
            Console.WriteLine();

            DerivedClass dc = new DerivedClass(ConsoleColor.Yellow);
            dc.Print("Test2");
            Console.WriteLine();

            DerivedClass dc1 = new DerivedClass(ConsoleColor.Red);
            dc1.Print("Test3");
            Console.WriteLine();

            DerivedClass dc2 = new DerivedClass(ConsoleColor.Magenta);
            dc2.Print("Test4");
            Console.WriteLine();

            Printer dc3 = (Printer)dc; //Upcast
            dc3.Print("Test5");
            Console.WriteLine();


            Console.ReadKey();

            

        }
    }
}
