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

    class ClassA { }

    class ClassB : ClassA { }

    class ClassC : ClassA { }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassC c = new ClassC();
            ClassA d = (ClassA)b;




            Car car = new Car();
            Transport carAsTransport = (Transport)car; // upcast

            Car car1 = (Car)carAsTransport; // downcast

            var cet = (CombustionEngineTransport)(new Car());
            if(cet is Car)
            {
                var cetAsCar = (Car)cet;
            }
            
        }
    }
}
