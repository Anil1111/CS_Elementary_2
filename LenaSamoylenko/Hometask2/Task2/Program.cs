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
<<<<<<< HEAD
=======
            Workers workers = new Workers();
            workers.addData("Ivanov I.I.", "ingeneer", new DateTime(year: 2008, month:01, day:01));
            workers.addData("Petrov I.N.", "driver", new DateTime(year:2001,month: 01, day: 01));
            workers.addData("Kurilov K.L.", "doctor", new DateTime(year:2016,month: 01, day: 01));
            workers.Print();
            workers.workersSorting(true);
            workers.orderWithCondition();
            Console.ReadLine();
>>>>>>> d97b4f3d2c90536bc82b1e9b6b94c094d92be9ef
        }
    }
}
