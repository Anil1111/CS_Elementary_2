using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(10000.78, 2013, 4);
            Print.printInfoAboutVehicle(car1);
            Plane plane1 = new Plane(10000000, 2013, 30);
            Print.printInfoAboutVehicle(plane1);
            Ship ship1 = new Ship(20000000, 2012, "Baikonur", 0);
            Print.printInfoAboutVehicle(ship1);
            Console.ReadKey();
        }
    }

}
