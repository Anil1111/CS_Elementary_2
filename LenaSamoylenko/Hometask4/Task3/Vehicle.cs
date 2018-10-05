using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Vehicle : countPassengersInVehicle
    {
        private double pointX;
        private double pointY;
        private double pointZ;
        private double price;
        private double velocity;
        private DateTime modelYear;

        public double PointX => pointX;
        public double PointY => pointY;
        public double PointZ => pointZ;
        public double Velocity => velocity;

        public double Price => price;
        public DateTime ModelYear => modelYear;

        public Vehicle(double price, int modelYear, int passengers)
        {
            this.pointX = 0;
            this.pointY = 0;
            this.pointZ = 0;
            this.price = price;
            this.velocity = 0;
            this.modelYear = new DateTime(modelYear, 01, 01);
            base.passengers = passengers;
        }
        public void coordinate(int x, int y, int z)
        {
            this.pointX = x;
            this.pointY = y;
            this.pointZ = z;
        }

    }
    abstract class countPassengersInVehicle
    {
        protected int passengers;
        public int Passengers => passengers;
    }

    static class Print
    {
        internal static void PrintData(Vehicle vehicle)
        {
            Console.WriteLine("Price:{0};\tModelYear:{1};\nPassengers:{2}\tVelocity:{3}", vehicle.Price, vehicle.ModelYear, vehicle.Passengers, vehicle.Velocity);
        }
        public static void printInfoAboutVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                PrintData(vehicle);
            }
            else if (vehicle is Plane)
            {
                PrintData(vehicle);
                Console.WriteLine("Height:{0};\t", ((Plane)vehicle).Height);
            }
            else if (vehicle is Ship)
            {
                PrintData(vehicle);
                Console.WriteLine("Port:{0};\t", ((Ship)vehicle).Port);
            }
            else
            { Console.WriteLine("Some error"); }

        }

    }

}
