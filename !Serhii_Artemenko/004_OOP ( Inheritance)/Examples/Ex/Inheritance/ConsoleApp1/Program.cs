using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Transport
    {
        public double Velocity;
        public double KilometerPrice;
        public int Capasity;
    }

    class CombustionEngineTransport : Transport
    {
        public double EngineVolume;
        public double EnginePower;
    }

    enum ControlType
    {
        Forward,
        Backward
    }

    class Car : CombustionEngineTransport
    {
        public ControlType Control;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Transport carAsTransport = (Transport)car; // upcast

            Car car1 = (Car)carAsTransport; // downcast

            var cet = (CombustionEngineTransport)(new Car());

            var cetAsCar = (Car)cet;


        }
    }
}
