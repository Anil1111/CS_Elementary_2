using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVehicle
{
    class Plane : Vehicle
    {
        private int passengers;
        private int height;



        public Plane(int cordinateX, int cordinateY, int price, int speed, int year, int passengers, int height) : base(cordinateX, cordinateY, price, speed, year)
        {
            this.passengers = passengers;
            this.height = height;


        }

        public override string info { get { return $"\nCordinates X n Y: {cordinateX}, {cordinateY}\nPrice: {price}\nSpeed: {speed}\nConstruction Year: {year}\nHeight: {height}\nNumber of passengers: {passengers}"; } }
    }
}
