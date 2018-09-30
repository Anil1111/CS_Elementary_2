using System;

namespace Task4
{
    partial class Program
    {
        class Rectangle
        {
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Area { get; private set; }
            public double Perimeter { get; private set; }

            public Rectangle(double side1, double side2)
            {
                Side1 = side1;
                Side2 = side2;
            }
            double AreaCalculator()
            {
                Area = Side1 * Side2;
                return Area;
            }
            double PerimeterCalculator()
            {
                Perimeter = (Side1 + Side2) * 2;
                return Perimeter;
            }

            public void write()
            {
                Console.WriteLine("Введите длину сторон прямоугольника");
                Console.Write("Сторона AB-");
                Side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Сторона BC-");
                Side2 = Convert.ToDouble(Console.ReadLine());
            }

            public void print()
            {
                double showArea=AreaCalculator();
                double showPerimetr=PerimeterCalculator();
                Console.WriteLine("Площадь  = "+showArea);
                Console.WriteLine("Периметр = "+showPerimetr);
            }         
        }
    }
}
