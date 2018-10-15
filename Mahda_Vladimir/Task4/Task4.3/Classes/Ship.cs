using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3.Classes
{
    class Ship : Vehicle
    {
        private int shipPassengerCapacity;
        private string shipsHomePort;

        public int ShipPassengerCapacity { get => shipPassengerCapacity; set => shipPassengerCapacity = value; }
        public string ShipsHomePort { get => shipsHomePort; set => shipsHomePort = value; }

        public Ship(int vehicleCoordinateX, int vehicleCoordinateY, double vehiclePrice, double vehicleSpeed, int vehicleProductionYear, int shipPassengerCapacity, string shipsHomePort)
            : base(vehicleCoordinateX, vehicleCoordinateY, vehiclePrice, vehicleSpeed, vehicleProductionYear)
        {
            this.shipPassengerCapacity = shipPassengerCapacity;
            this.shipsHomePort = shipsHomePort;
        }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine($"| Passenger сapacity: {shipPassengerCapacity} people| Ship's home port: {shipsHomePort}");
        }



    }
}
