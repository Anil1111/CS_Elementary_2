using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    
    class Vehicle
    {
        protected int pointX;
        protected int pointY;
        protected double price;
        protected double speed;
        protected DateTime year;

        public int PointX { get => pointX;  }
        public int PointY { get => pointY;  }
        public double Price { get => price;  }
        public double Speed { get => speed; }
        public DateTime Year { get => year; }
        public Vehicle()
        {

        }
        public Vehicle(int x, int y, double price, double speed, DateTime year)
        {
            pointX = x;
            pointY = y;
            this.price = price;
            this.speed = speed;
            this.year = year;

        }
        public override string ToString()
        {
            return string.Format("Location: " + pointX + " " + pointY + "\nPrice:" + price + "\nSpeed: " + speed + " \nYear: " + year);
        }

    }
}
