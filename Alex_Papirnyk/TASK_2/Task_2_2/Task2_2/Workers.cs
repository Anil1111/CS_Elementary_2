using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Workers
    {
        List<Worker> workers;
        

        public Workers()
        {
            workers = new List<Worker>();
          
        }
        public void InputData(Worker worker)
        {
            workers.Add(worker);
        }
        private void Show(Worker worker)
        {
            Console.WriteLine($"{worker.Name} ->{worker.Position} ->{worker.Year}");
        }
       
       /* public void Print()
        {
            List<Worker> tempList = new List<Worker>();
            tempList = workers.OrderBy(x => x.Name).ToList();
            foreach (var temp in workers)
            {
                Show(temp);
            }
        }*/
        public void workersSorting(bool Sorting)
        {
            List<Worker> tempList = new List<Worker>();
            if (Sorting)
            {
                tempList = workers.OrderBy(x => x.Name).ToList();
            }
            Print(tempList);
        }
        private void Print(List<Worker> workers)
        {
            
            foreach (var worker in workers)
            {
                Show(worker);
            }
        }

        public void Print(int userYear)
        {
            foreach(var worker in workers)
            {
                if(worker.Year>userYear)
                {
                    Show(worker);
                }
            }

        }



    }
}
