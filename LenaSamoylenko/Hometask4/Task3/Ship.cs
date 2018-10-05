using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship:Vehicle
    {
        private double port;
        public double Port => port;
        public Ship(double price, int modelYear, double port) : base(price, modelYear)
        {
            this.port = port;
        }

        //выполнить наследование вложенного класса Vihicle 

    }
}
