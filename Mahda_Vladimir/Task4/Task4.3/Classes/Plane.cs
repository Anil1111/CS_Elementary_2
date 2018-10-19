using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3.Classes
{
    class Plane : Vehicle
    {
        private int planeAltitude;
        private int planePassengerCapacity;

        public int PlaneAltitude { get => planeAltitude; set => planeAltitude = value; }
        public int PlanePassengerCapacity { get => planePassengerCapacity; set => planePassengerCapacity = value; }

        public Plane(int vehicleCoordinateX, int vehicleCoordinateY, double vehiclePrice, double vehicleSpeed, int vehicleProductionYear, int planeAltitude, int planePassengerCapacity)
            : base(vehicleCoordinateX, vehicleCoordinateY, vehiclePrice, vehicleSpeed, vehicleProductionYear)
        {
            this.planeAltitude = planeAltitude;
            this.planePassengerCapacity = planePassengerCapacity;
        }

        public override void ShowVehicle()
        {
            base.ShowVehicle();
            Console.WriteLine($"| Altitude: {PlaneAltitude} m| Passenger сapacity: {PlanePassengerCapacity} people");
        }
    }


}
