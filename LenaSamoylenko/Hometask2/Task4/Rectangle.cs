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
        public double Side1=>side1;
        public double Side2 => side2;
        public Rectangle()
        {
            this.side1 = getResult("first lenght");
            this.side2 = getResult("second lenght");
        }
        public double Area => AreaCalculator(); 
        public double Perimeter =>PerimeterCalculator();



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
            
            Console.WriteLine("Area is:\t {0}", Area);
            Console.WriteLine("Perimetr is:\t {0}", Perimeter);

        }
        private double getResult(string message)
        {
            Console.WriteLine("Put {0} lenght", message);
            double l1 = Convert.ToDouble(Console.ReadLine());
            return l1;
        }

    }
}
