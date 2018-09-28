using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class PerimeterCalculatorClass
    {
        public static double PerimeterCalculator(Rectangle rectangle)
        {
            return (2 * rectangle.side1 + 2 * rectangle.side2);
        }
    }
}
