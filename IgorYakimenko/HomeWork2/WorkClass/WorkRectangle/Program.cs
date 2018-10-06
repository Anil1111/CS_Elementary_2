using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите ширину прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            CRectangle rectangle = new CRectangle(side1, side2);
            
            Console.WriteLine();
            Console.WriteLine(@"Площадь прямоугольника = {0}",rectangle.AreaCalculator());
            Console.WriteLine(@"Периметр прямоугольника = {0}",rectangle.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}
