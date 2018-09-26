using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker
    {
        private string fullName;
        private string position;
        private int yearStartWorking;
        List<Worker> work = new List<Worker>();
        public void addData(string fullName, string position, int yearStartWorking)
        {
            Worker person1 = new Worker();
            person1.fullName = fullName;
            person1.position = position;
            person1.yearStartWorking = yearStartWorking;
            work.Add(person1);
        }

        
        public List<Worker> orderDataSecondName()
        {
            work = work.OrderBy(o => o.fullName).ToList();
            return work;
        }

        public void orderWithCondition(List<Worker> work)
        {
            int userCondition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All positions");
            foreach (Worker c in work)
            {
                if (c.yearStartWorking > userCondition)
                {
                    Console.Write($"{c.fullName}\t");
                    Console.Write($"{c.position}\t\t");
                    Console.Write($"{c.yearStartWorking}");
                }
                else { Console.WriteLine("This count isn`t bigger than your condition"); }

            }
        }
    }


}
