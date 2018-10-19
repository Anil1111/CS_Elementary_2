using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3.Classes
{
    public class Vehicle
    {
        private int vehicleCoordinateX;
        private int vehicleCoordinateY;
        private double vehiclePrice;
        private double vehicleSpeed;
        private int vehicleProductionYear;

        public int VehicleCoordinateX { get => vehicleCoordinateX; set => vehicleCoordinateX = value; }
        public int VehicleCoordinateY { get => vehicleCoordinateY; set => vehicleCoordinateY = value; }
        public double VehiclePrice { get => vehiclePrice; set => vehiclePrice = value; }
        public double VehicleSpeed { get => vehicleSpeed; set => vehicleSpeed = value; }
        public int VehicleProductionYear { get => vehicleProductionYear; set => vehicleProductionYear = value; }

        public Vehicle(int vehicleCoordinateX, int vehicleCoordinateY, double vehiclePrice, double vehicleSpeed, int vehicleProductionYear )
        {
            this.vehicleCoordinateX = vehicleCoordinateX;
            this.vehicleCoordinateY = vehicleCoordinateY;
            this.vehiclePrice = vehiclePrice;
            this.vehicleSpeed = vehicleSpeed;
            this.vehicleProductionYear = vehicleProductionYear;
        }

        public virtual void ShowVehicle()
        {
            Console.WriteLine($"This is the {this.GetType().Name}");
            Console.Write($"CoordinateX: {VehicleCoordinateX,0 - 5}| CoordinateY: {VehicleCoordinateY,0 - 5}| Price: {VehiclePrice}$| Speed: {VehicleSpeed} mph| Year: {VehicleProductionYear, 0-5}");
        }
    }
}
