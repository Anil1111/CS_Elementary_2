using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
   
    
     
    class Plane :Vehicle
    {
        private double height;
        private int passCount;

        public double Height { get => height;  }
        public int PassCount { get => passCount;  }
        public Plane()
        {

        }
        public Plane(int x, int y, double price, double speed, DateTime year, int passCount) :base(x,y,price,speed,year)
        {
           
            this.passCount = passCount;
            height = pointY;
            

        }
       
        public override string ToString()
        {
            return string.Format("Height:" + height + "\nPrice:" + price + "\nSpeed:" + speed + "\nYear:" + year+"\nNumber of passengers:"+passCount);
        }
    }
}
