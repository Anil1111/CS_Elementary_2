using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3.Classes
{
    class Car : Vehicle
    {
        public Car(int vehicleCoordinateX, int vehicleCoordinateY, double vehiclePrice, double vehicleSpeed, int vehicleProductionYear)
            : base(vehicleCoordinateX, vehicleCoordinateY, vehiclePrice, vehicleSpeed, vehicleProductionYear)
        {    }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine();
        }

    }
}
