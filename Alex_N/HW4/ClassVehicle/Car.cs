using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVehicle
{
    class Car : Vehicle
    {
        private bool dorkDriver;

        public Car(int cordinateX, int cordinateY, int price, int speed, int year, int result) : base(cordinateX, cordinateY, price, speed, year)
        {
            if (result == 0)
            {
                dorkDriver = false;
            }
            else
            {
                dorkDriver = true;
            }
        }
        private string DorkOrNot()
        {
            if (dorkDriver)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public override string info { get { return $"\nCordinates X n Y: {cordinateX}, {cordinateY}\nPrice: {price}\nSpeed: {speed}\nConstruction Year: {year}\nIs driver a dork?: {DorkOrNot()}"; } }

    }
}
