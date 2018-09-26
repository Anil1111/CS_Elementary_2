using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Rectangle
    {
        private double side1, side2;
        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double Area { get { return AreaCalculator(); } }
        private double Perimeter { get { return PerimeterCalculator(); } }

        private double AreaCalculator()
        {
            double result = side1 * side2;
            return result;
        }
        private double PerimeterCalculator()
        {
            double result = 2 * (side1 + side2);
            return result;
        }

        public void printResult()
        {
            side1 = getResult("first");
            side2 = getResult("second");
            Console.WriteLine("Area is:\t {0}", AreaCalculator());
            Console.WriteLine("Perimetr is:\t {0}",PerimeterCalculator());

        }
        private double getResult(string message)
        {
            Console.WriteLine("Put {0} lenght", message);
            double l1 = Convert.ToDouble(Console.ReadLine());
            return l1;
        }

    }
}
