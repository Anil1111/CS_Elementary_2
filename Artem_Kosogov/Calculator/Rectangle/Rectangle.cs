using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public double side1;
        public double side2;

        public double Area
        {
            get
            {
                return AreaCalculatorClass.AreaCalculator(this);
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculatorClass.PerimeterCalculator(this);
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public Rectangle()
        {
            side1 = 0;
            side2 = 0;
        }

       

        
    }
}
