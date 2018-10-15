using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers workerList = new Workers();
            Worker worker1 = new Worker("Alex Papirnyk", "Junior", 1);
            Worker worker2 = new Worker("Bill Gates", "Senior", 10);
            Worker worker3 = new Worker("Serhii Artemenko", "Senior", 7);
            
            workerList.InputData(worker1);
            workerList.InputData(worker3);
            workerList.InputData(worker2);
            workerList.workersSorting(Sorting: true);
            Console.WriteLine(new string('-', 40));
            workerList.Print(3);




            Console.ReadLine();

        }
    }
}
