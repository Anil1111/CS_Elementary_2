using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(10, 20, "A");
            Point B = new Point(4, 5, "B");
            Point C = new Point(3, 6, "C");
            Figure figure = new Figure(A, B, C);
            figure.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
