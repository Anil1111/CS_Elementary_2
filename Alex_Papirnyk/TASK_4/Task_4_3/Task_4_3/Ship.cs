using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    class Ship:Vehicle
    {
        private string port;
        private int passCount;

        public string Port { get => port;  }
        public int PassCount { get => passCount; }
        public Ship()
        {
                
        }
        public Ship(int x, int y, double price, double speed,DateTime year, string port, int passCount) : base(x, y, price, speed, year)
        {
            this.port = port;
            this.passCount = passCount;

        }
        public override string ToString()
        {
            return string.Format("Location:" + pointX + " " + pointY + "\nPrice:" + price + "\nSpeed:" + speed + "\nYear:" + year+"\nNumber of passengers:"+passCount+"\nPort:"+port);
        }
    }
}
