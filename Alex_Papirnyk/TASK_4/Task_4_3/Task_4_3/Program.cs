using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Vehicle(0, 0, 1000, 155.5,new DateTime(1999,10,01));
            Console.WriteLine(vh.ToString());
            Console.WriteLine(new string('-', 40));
            Plane pl = new Plane(0,1000,144144,250.5,new DateTime(2015,05,04),100);
            Console.WriteLine(pl.ToString());
            Console.WriteLine(new string('-', 40));
            Ship sp = new Ship(1500, 1500, 15000, 300, new DateTime(2007, 03, 03),"Dnepr",1000);
            Console.WriteLine(sp.ToString());
            Vehicle test = new Plane(10, 10, 100, 15433, new DateTime(2000, 10, 10), 50);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(test.ToString());
           

            Console.ReadLine();
        }
    }
}
