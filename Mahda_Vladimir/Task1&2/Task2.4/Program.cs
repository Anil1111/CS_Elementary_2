using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создать класс с именем Rectangle.
//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
//поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
//прямоугольника - double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
//на экран периметр и площадь.
namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;
            Console.WriteLine("This is rectangle calculator");
            side1 = Rectangle.InputUsersData("side1");
            side2 = Rectangle.InputUsersData("side2");
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Area ======> {rectangle.Area}");
            Console.WriteLine($"Perimeter => {rectangle.Perimeter}");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Area ======> {rectangle.AreaCalculator(side1, side2)}");
            Console.WriteLine($"Perimeter => {rectangle.PerimeterCalculator(side1, side2)}");

            Console.ReadKey();

        }
    }
}
