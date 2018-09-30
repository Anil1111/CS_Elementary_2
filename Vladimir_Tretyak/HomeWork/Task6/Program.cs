using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
//6. Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//аргументов.Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
//аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
//многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace Task6
{
    class Point
    {
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }

    class Figure
    {
        Point A;
        Point B;
        Point C;
        Point D;
        Point E;

        public Figure(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            D = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            E = e;
        }

       public double LengthSide(Point A, Point B)
        {
            double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - B.Y, 2));
            return a;
        }
        void PerimeterCalculator()
        {

        }
    }
    class Points
    {
        List<Point> pointsF;
        public Points()
        {
            pointsF = new List<Point>();
        }
         public void inputUserData(Point newPoint)//Добавляем элементы в список типа Prise
        {
            pointsF.Add(newPoint);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Points p = new Points();
            string nameP=null;
            int x=0;
            int y=0;
            nameP = "A";
            x = 20;
            y = 30;
            Point A = new Point(nameP, x, y);
            p.inputUserData(A);
            Console.ReadLine();
        }
    }
}
