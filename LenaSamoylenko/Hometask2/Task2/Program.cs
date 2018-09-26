using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker person1 = new Worker();
            person1.addData("SmithJK", "driver", 1990);
            person1.addData("BinKR", "manager", 2010);
            person1.addData("BinKR", "manager", 2012);
            person1.orderDataSecondName();
            Console.ReadKey();
        }
    }
}
