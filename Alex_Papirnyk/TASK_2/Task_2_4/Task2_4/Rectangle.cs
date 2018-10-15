using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{/*
    
    
    Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
    */
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Side1 { get => side1;  }
        public double Side2 { get => side2;  }
        public Rectangle()
        {
            side1 = GetData();
            side2 = GetData1();
        }
        public double GetData()
        {
            Console.WriteLine("Input length");
            double l = Convert.ToDouble(Console.ReadLine());
            return l;

        }
        public double GetData1()
        {
            Console.WriteLine("Input length of second");
            double l = Convert.ToDouble(Console.ReadLine());
            return l;

        }
        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double result = side1 * side2;
            return result;
        }
        public double PerimeterCalculator()
        {
            double result = (side1 * 2) + (side2 * 2);
            return result;
        }
        public double Area { get=>AreaCalculator(); }
        public double Perimeter { get=>PerimeterCalculator(); }
        public void Print()
        {
            Console.WriteLine("Area is {0} and periment is {1} ", Area, Perimeter);
        }

    }
}
