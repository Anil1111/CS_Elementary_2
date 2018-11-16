using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVehicle
{
    class Vehicle
    {
        protected int cordinateX;
        protected int cordinateY;
        protected int price;
        protected int speed;
        protected int year;

        public Vehicle(){}//по умолчанию

        public Vehicle(int cordinateX, int cordinateY, int price, int speed, int year)//польз
        {
            this.cordinateX = cordinateX;
            this.cordinateY = cordinateY;
            this.price = price;
            this.speed = speed;
            this.year = year;

        }

        public virtual string info { get { return $"\nCordinates X n Y: {cordinateX}, {cordinateY}\nPrice: {price}\nSpeed: {speed}\nConstruction Year: {year}"; } }


    }
}
