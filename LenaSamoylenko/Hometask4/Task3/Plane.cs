using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Plane : Vehicle
    {
        private double height;
        public double Height => height;
        public Plane(double price, int modelYear, int passengers) : base(price, modelYear, passengers) { }

        public void heightDefinition()
        {
            height = PointY;
            Console.WriteLine("Height is {0}", height);

        }

        //выполнить наследование вложенного класса в  Vihicle 
    }
}
