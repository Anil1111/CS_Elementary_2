using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Figure
    {

        List<double> Side = new List<double>();
        private double perimetr => PerimeterCalculator();
        public double Perimetr => perimetr;

        public Figure(Point p1, Point p2, Point p3)
        {
            polygonSideLenght(p1, p2);
            polygonSideLenght(p2, p3);
            polygonSideLenght(p3, p1);
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            polygonSideLenght(p1, p2);
            polygonSideLenght(p2, p3);
            polygonSideLenght(p3, p4);
            polygonSideLenght(p4, p1);
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            polygonSideLenght(p1, p2);
            polygonSideLenght(p2, p3);
            polygonSideLenght(p3, p4);
            polygonSideLenght(p4, p5);
            polygonSideLenght(p5, p1);
        }
        private void polygonSideLenght(Point p1, Point p2)
        {
            Side.Add(LengthSide(p1, p2));
        }

        private double LengthSide(Point A, Point B)
        {
            //тело метода
            double lenght = Math.Pow((A.xPoint - B.xPoint), 2) + Math.Pow((A.yPoint - B.yPoint), 2);
            lenght = Math.Sqrt(lenght);
            return lenght;
        }

        private double PerimeterCalculator()
        {
            double perimetr = Side.Sum();
            return perimetr;
        }

        public void printName()
        {
            if (Side.Count == 3)
            {
                Console.WriteLine("This is triangle");

            }
            else if (Side.Count == 4)
            {
                Console.WriteLine("This is tetragon");
            }
            else
            {
                Console.WriteLine("This is pentagon");
            }
        }
    }
}
