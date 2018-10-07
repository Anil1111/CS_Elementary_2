using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Point
    {
        private int x, y;
        private string comment;
        public int xPoint => x; 
        public int yPoint =>y; 
        public string Comment => comment;

        public Point(int x, int y, string comment)
        {
            this.x = x;
            this.y = y;
            this.comment = comment;
        }
    }
}
