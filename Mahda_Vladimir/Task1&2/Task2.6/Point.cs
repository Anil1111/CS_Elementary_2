using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    class Point
    {
        private int coordX;
        private int coordY;
        private string pointTitle;

        public int CoordX { get => coordX; }
        public int CoordY { get => coordY; }
        public string PoinTitle { get => pointTitle; }

        public Point(int coordX, int coordY, string pointTitle)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.pointTitle = pointTitle;
        }
    }
}
