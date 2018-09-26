using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "точка А");
            Point B = new Point(0, 1, "точка В");
            Point C = new Point(1, 1, "точка C");
            Point D = new Point(1, 0, "точка D");
            //Point E = new Point(7, 8, "точка E");
            //Figure figure = new Figure(A, B, C);
            Figure figure = new Figure(A, B, C, D);
            //Figure figure = new Figure(A, B, C, D, E);
            figure.Print();
            Console.ReadLine();
        }
    }
}
