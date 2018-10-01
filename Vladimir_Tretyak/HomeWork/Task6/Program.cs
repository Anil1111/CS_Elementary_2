using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

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
        Point A, B, C, D, E;
        public Figure(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        //Конструкторы для создания фигур с разным количеством точек
        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            D = d;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            E = e;
        }
        public double LengthSide(Point A, Point B)//Вычисляем длину сторон фигуры
        {
            double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - B.Y, 2));
            return a;
        }
        //Методы вычисления периметра 
        public void PerimeterCalculator(double a, double b, double c)
        {
            double P;
            P = a + b + c;
            Console.WriteLine($"Длина сторон :\na={a},\nb={b},\nc={c}");
            Console.WriteLine("Периметр треугольника =  " + P);
        }
        public void PerimeterCalculator(double a, double b, double c, double d)
        {
            double P;
            P = a + b + c + d;
            Console.WriteLine($"Длина сторон :\na={a},\nb={b},\nc={c},\nd={d}");
            Console.WriteLine("Периметр четырёхугольника =  " + P);

        }
        public void PerimeterCalculator(double a, double b, double c, double d, double e)
        {
            double P;
            P = a + b + c + d + e;
            Console.WriteLine($"Длина сторон :\na={a},\nb={b},\nc={c},\nd={d},\ne={e}");
            Console.WriteLine("Периметр пятиугольника =  " + P);
        }
    }
    class Points
    {
        public List<Point> pointsF;
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
            //Вспомогательные поля для наполнения списка "pointsF" с клавиатуры
            string nameP = null;
            int x = 0;
            int y = 0;
            //Счётчик точек фигуры
            int pointCount = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите от 3-х до 5 точек многоугольника.\nНазвание новой точки:");
                nameP = Console.ReadLine();
                Console.WriteLine("Введите координаты нахождения точки:" + nameP);
                Console.Write("x = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Point newPoint = new Point(nameP, x, y);
                p.inputUserData(newPoint);
                pointCount++;
                if (pointCount < 3)
                {
                    Console.WriteLine("Введите новую точку (Enter), всего точек " + pointCount);
                }
                else
                {
                    Console.WriteLine("Нажмите Enter для продолжения ввода или Esc для окончания ввода,всего точек "+pointCount);
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Write("Для расчёта длин сторон и периметра многоугольника нажмите Enter");
            Console.ReadLine();
            //Производим обработку согласно количеству полученных точек
            switch (pointCount)
            {
                case 3:
                    double[] sidesOftriangle = new double[3];
                    Figure triangle = new Figure(p.pointsF[0], p.pointsF[1], p.pointsF[2]);
                    sidesOftriangle[0] = triangle.LengthSide(p.pointsF[0], p.pointsF[1]);
                    sidesOftriangle[1] = triangle.LengthSide(p.pointsF[1], p.pointsF[2]);
                    sidesOftriangle[2] = triangle.LengthSide(p.pointsF[2], p.pointsF[0]);
                    triangle.PerimeterCalculator(sidesOftriangle[0], sidesOftriangle[1], sidesOftriangle[2]);
                    break;
                case 4:
                    double[] sidesOfquadrangle = new double[4];
                    Figure quadrangle = new Figure(p.pointsF[0], p.pointsF[1], p.pointsF[2], p.pointsF[3]);
                    sidesOfquadrangle[0] = quadrangle.LengthSide(p.pointsF[0], p.pointsF[1]);
                    sidesOfquadrangle[1] = quadrangle.LengthSide(p.pointsF[1], p.pointsF[2]);
                    sidesOfquadrangle[2] = quadrangle.LengthSide(p.pointsF[2], p.pointsF[3]);
                    sidesOfquadrangle[3] = quadrangle.LengthSide(p.pointsF[3], p.pointsF[0]);
                    quadrangle.PerimeterCalculator(sidesOfquadrangle[0], sidesOfquadrangle[1],
                                                   sidesOfquadrangle[2], sidesOfquadrangle[3]);
                    break;
                case 5:
                    double[] sidesOfpentagon = new double[5];
                    Figure pentagon = new Figure(p.pointsF[0], p.pointsF[1], p.pointsF[2], p.pointsF[3], p.pointsF[4]);
                    sidesOfpentagon[0] = pentagon.LengthSide(p.pointsF[0], p.pointsF[1]);
                    sidesOfpentagon[1] = pentagon.LengthSide(p.pointsF[1], p.pointsF[2]);
                    sidesOfpentagon[2] = pentagon.LengthSide(p.pointsF[2], p.pointsF[3]);
                    sidesOfpentagon[3] = pentagon.LengthSide(p.pointsF[3], p.pointsF[4]);
                    sidesOfpentagon[4] = pentagon.LengthSide(p.pointsF[4], p.pointsF[0]);
                    pentagon.PerimeterCalculator
                    (sidesOfpentagon[0], sidesOfpentagon[1], sidesOfpentagon[2], sidesOfpentagon[3], sidesOfpentagon[4]);
                    break;
            }
            Console.ReadLine();
        }
    }
}
