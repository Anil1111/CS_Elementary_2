using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Ship : Vehicle
    {
        private string port;
        public string Port => port;
        public Ship(double price, int modelYear, string port, int passengers) : base(price, modelYear, passengers)
        {
            this.port = port;
        }

        //выполнить наследование вложенного класса Vihicle 

    }
}
