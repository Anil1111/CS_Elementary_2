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
        public int xPoint { get { return x; } }
        public int yPoint { get { return y; } }
        public string Comment { get { return comment; } }

        internal Point(int putX, int putY, string putComment)
        {
            x = putX;
            y = putY;
            comment = putComment;
        }
    }
}
