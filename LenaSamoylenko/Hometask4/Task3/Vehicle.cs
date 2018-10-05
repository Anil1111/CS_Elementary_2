using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Vehicle
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

        public Vehicle(double price, int modelYear)
        {
            this.pointX = 0;
            this.pointY = 0;
            this.pointZ = 0;
            this.price = price;
            this.velocity = 0;
            this.modelYear = new DateTime(modelYear, 01, 01);
        }
        public void coordinate(int x, int y, int z)
        {
            this.pointX = x;
            this.pointY = y;
            this.pointZ = z;
        }
    }
    class countPassengersInVehicle
    {
        private int passengers;
        public int Passengers => passengers;
        public countPassengersInVehicle(int passengers) { this.passengers = passengers; }
    }

}
