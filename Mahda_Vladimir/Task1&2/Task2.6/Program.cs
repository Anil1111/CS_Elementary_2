using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
//многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Task2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 10, "B");
            Point C = new Point(10, 10, "C");
            Point D = new Point(10, 0, "D");
            Point E = new Point(-5, 5, "E");
            Point F = new Point(-10, 0, "F");

            Figurine fig1 = new Figurine(A, B, C);
            Figurine fig2 = new Figurine(A, B, C, D);
            Figurine fig3 = new Figurine(A, B, C, D, E);
            Figurine fig4 = new Figurine(A, B, C, D, F);

            fig1.PerimeterCalculator();
            Console.WriteLine(new string('-', 50));
            fig2.PerimeterCalculator();
            Console.WriteLine(new string('-', 50));
            fig3.PerimeterCalculator();
            Console.WriteLine(new string('-', 50));
            fig4.PerimeterCalculator();
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
