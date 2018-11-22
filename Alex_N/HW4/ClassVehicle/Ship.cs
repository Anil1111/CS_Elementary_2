using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVehicle
{
    class Ship : Vehicle
    {
        private int passengers;
        private string port;



        public Ship(int cordinateX, int cordinateY, int price, int speed, int year, int passengers, string port) : base(cordinateX, cordinateY, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;


        }

        public override string info { get { return $"\nCordinates X n Y: {cordinateX}, {cordinateY}\nPrice: {price}\nSpeed: {speed}\nConstruction Year: {year}\nNative Pport: {port}\nNumber of passengers: {passengers}"; } }
    }
}
