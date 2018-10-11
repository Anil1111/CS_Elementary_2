using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    class Figurine
    {
        Point point1;
        Point point2;
        Point point3;
        Point point4;
        Point point5;
        String figurineTitle;

        public Figurine(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            figurineTitle = "Triangle";
        }

        public Figurine(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            figurineTitle = "Tetragon";
        }

        public Figurine(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            figurineTitle = "Pentagon";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Pow(Math.Pow((A.CoordX - B.CoordX), 2) + Math.Pow((A.CoordY - B.CoordY), 2), 0.5);
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            switch (figurineTitle)
            {
                case "Triangle":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point1);
                    break;

                case "Tetragon":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4)+ LengthSide(point4, point1);
                    break;
                case "Pentagon":
                    perimeter = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1);
                    break;
            }
            Console.WriteLine($"Figurine is a {figurineTitle}. Perimetre is {perimeter}.");
        }
    }
}
