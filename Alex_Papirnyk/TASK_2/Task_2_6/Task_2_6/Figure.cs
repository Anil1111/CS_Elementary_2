using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
   
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public Figure()
        {

        }

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        private Point[] points;
        private double lengthside;
        public double LengthSide(Point pointA, Point pointB)
        {
            lengthside = Math.Pow((pointA.X - pointB.Y), 2) + Math.Pow((pointA.X - pointB.Y), 2);
            lengthside = Math.Sqrt(lengthside);
            return lengthside;
        }
      
      
        public void PerimeterCalculator() 
        {
            double perimeter = 0;
            string Name = string.Empty;

            if (E != null)
            {
                points = new Point[5];
                points[0] = A;
                points[1] = B;
                points[2] = C;
                points[3] = D;
                points[4] = E;
                Name = "Пятиугольник";
            }
            else if (E == null && D != null)
            {
                points = new Point[4];
                points[0] = A;
                points[1] = B;
                points[2] = C;
                points[3] = D;
                Name = "Прямоугольник";
            }
            else
            {
                points = new Point[3];
                points[0] = A;
                points[1] = B;
                points[2] = C;
                Name = "Треугольник";
            }

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);

            Console.WriteLine(@"Название многоугольника : {0}", Name);
            Console.WriteLine(@"Периметер многоугольника : {0}", perimeter);
        }

    }
}
