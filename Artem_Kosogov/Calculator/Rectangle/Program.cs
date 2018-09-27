using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Please, enter length of the rectangle");
            rectangle.side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter width of the rectangle");
            rectangle.side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the rectangle = "+rectangle.Area);
            Console.WriteLine("Perimeter of the rectangle = "+ rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
