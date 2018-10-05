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
        private double passengers;
        public double Height => height;
        public double Passengers => passengers;
        public Plane(double price, int modelYear) : base(price, modelYear) { }

        public void heightDefinition()
        {
            height = PointY;
            Console.WriteLine("Height is {0}", height);

        }

        //выполнить наследование вложенного класса в  Vihicle 
    }
}
