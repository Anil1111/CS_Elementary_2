using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Point
    {
        private int x;
        private int y;
        private string comment;

        public int X { get => x; }
        public int Y { get => y;}
        public string Comment { get => comment; }
        public Point()
        {

        }
        public Point(int x,int y, string comment)
        {
            this.x = x;
            this.y = y;
            this.comment = comment;

        }

    }
}
