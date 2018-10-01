using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Workers
    {
        List<Worker> workers;
        public Workers()
        {
            workers = new List<Worker>();
        }


        public void addData(string fullName, string position, DateTime yearStartWorking)
        {
            Worker person = new Worker(fullName, position, yearStartWorking);
            workers.Add(person);
        }

        private void Show(string fullName, string position, DateTime yearStartWorking)
        {
            Console.WriteLine("fullName:{0}, position:{1}, yearStartWorking:{2}", fullName, position, yearStartWorking.Year);
        }

        public void Print()
        {
            Console.WriteLine("All workers");
            foreach (var worker in workers)
            {
                Show(worker.FullName, worker.Position, worker.YearStartWorking);
            }
        }

        private void Print(List<Worker> workers, string message)
        {
            Console.WriteLine(message);
            foreach (var worker in workers)
            {
                Show(worker.FullName, worker.Position, worker.YearStartWorking);
            }
        }

        public void orderWithCondition()
        {
            Console.WriteLine("Put you condition");
            int userCondition = Convert.ToInt32(Console.ReadLine());
            foreach (var worker in workers)
            {
                if ((DateTime.Now.Year - worker.YearStartWorking.Year) >= userCondition)
                {
                    Show(worker.FullName, worker.Position, worker.YearStartWorking);
                }
            }

        }


        public void workersSorting(bool Sorting)
        {
            List<Worker> tempList = new List<Worker>();
            if (Sorting)
            {
                tempList = workers.OrderBy(x => x.FullName).ToList();
            }
            Print(tempList, "Workers in alphabetically order");
        }


    }

}

