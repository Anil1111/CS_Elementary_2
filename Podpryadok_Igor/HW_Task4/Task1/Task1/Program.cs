﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
//и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, 
//выводились разными цветами.
//Обязательно используйте приведение типов.
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Red red = new Red();
            Blue blue = new Blue();
            blue.Print("Hello World!");
            red.Print("Hello World!");
            Console.ReadLine();
        }
    }
}
