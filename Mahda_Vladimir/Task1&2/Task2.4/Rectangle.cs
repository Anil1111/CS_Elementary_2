using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public double Side1 { get => side1; }
        public double Side2 { get => side2; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }

        public double PerimeterCalculator(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }

        public double Area { get { return this.Side1 * this.Side2; } }
        public double Perimeter { get { return 2 * (this.Side1 + this.Side2); } }

        public static double InputUsersData(string message)
        {
            double side;
            do
            {
                Console.Write($"Input {message} =>");
            } while (!double.TryParse(Console.ReadLine(), out side));
            return side;
        }
    }
}
