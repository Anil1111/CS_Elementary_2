using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item3
{
    class Vehicle
    {
        private double coordinateX, coordinateY, cost, speed, yearManufacture;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double YearManufacture
        {
            get { return yearManufacture; }
            set { yearManufacture = value; }
        }

        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

        public void SpeedMethod(double Speed)
        {
            this.Speed = Speed;
        }
    }
}