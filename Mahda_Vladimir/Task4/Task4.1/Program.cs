using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте класс Printer.В теле класса создайте метод void Print(string value), 
//который выводит на экран значение аргумента.Реализуйте возможность того, 
//чтобы в случае наследования от данного класса других классов, и вызове 
//соответствующего метода их экземпляра, строки, переданные в качестве 
//аргументов методов, выводились разными цветами.Обязательно используйте приведение типов.

namespace Task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Printer_red printer_red = new Printer_red();
            Printer_blue printer_blue = new Printer_blue();

            printer.Print("base printer");
            printer_red.Print("derived printer");
            printer_blue.Print("derived printer");

            Printer printerNew = (Printer)printer_red;
            printerNew.Print("base printer upcast");

            printerNew = (Printer)printer_blue;
            printerNew.Print("base printer upcast");

            Console.ReadKey();
        }
    }
}
