using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Figure
    {

        public double[] l = new double[5];
        public double perimetr;
        public Figure(Point p1, Point p2, Point p3)
        {
            l[0] = LengthSide(p1, p2);
            l[1] = LengthSide(p2, p3);
            l[2] = LengthSide(p1, p3);
        }

        public Figure() { }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            l[0] = LengthSide(p1, p2);
            l[1] = LengthSide(p2, p3);
            l[2] = LengthSide(p3, p4);
            l[3] = LengthSide(p4, p1);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            l[0] = LengthSide(p1, p2);
            l[1] = LengthSide(p2, p3);
            l[2] = LengthSide(p3, p4);
            l[3] = LengthSide(p4, p5);
            l[4] = LengthSide(p5, p1);
        }

        private double LengthSide(Point A, Point B)
        {
            //тело метода
            double lenght = Math.Pow((A.xPoint - B.xPoint), 2) + Math.Pow((A.yPoint - B.yPoint), 2);
            lenght = Math.Sqrt(lenght);
            return lenght;
        }

        public void PerimeterCalculator()
        {
            perimetr = l.Sum();
            Console.WriteLine("Perimetr is:{0}", perimetr);
        }

        public void Print()
        {
            if (l[3] == 0 && l[4] == 0)
            {
                Console.WriteLine("This is triangle");

            }
            else if (l[4] == 0)
            {
                Console.WriteLine("This is tetragon");
            }
            else 
            {
                Console.WriteLine("This is pentagon");
            }
            PerimeterCalculator();

            Console.ReadLine();
        }
    }
}
