using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Workers
    {
        List<Worker> workers;
        List<Worker> tempWorkers;

        public Workers()
        {
            workers = new List<Worker>();
            tempWorkers = new List<Worker>();
        }

        public void inputUserData(Worker worker)
        {
            workers.Add(worker);
        }

        /// <summary>
        /// Вывод всех работников
        /// </summary>
        public void showWorkers()
        {
            foreach (var worker in workers)
            {
                worker.showWorker();
            }
        }

        /// <summary>
        /// Вывод сортированного по алфавиту списка работников
        /// </summary>
        /// <param name="isSorted">сортирован?</param>
        public void showWorkers(bool isSorted)
        {
            if (isSorted)
            {
                tempWorkers = workers.OrderBy(x => x.WorkerFIO).ToList();
                if(tempWorkers.Count >0)
                {
                    foreach (var worker in tempWorkers)
                    {
                        worker.showWorker();
                    }
                }
                else
                {
                    Console.WriteLine("List is empty");
                }
            }
        }

        /// <summary>
        /// вывод работников, чей стаж работы превышает введенное значение
        /// </summary>
        public void showWorkersWithExperience()
        {
            int yearFromUser;
            Console.Write($"Input year: ");
            if (!Int32.TryParse(Console.ReadLine(), out yearFromUser))
            {
                Console.WriteLine("Input error");
            }
            else
            {
                bool haveWorkerWithExperians = false;
                foreach (Worker worker in workers)
                {
                    if (worker.YearOfEmployment< yearFromUser)
                    {
                        worker.showWorker();
                        haveWorkerWithExperians = true;
                    }
                }
                if (!haveWorkerWithExperians)
                {
                    Console.WriteLine("No workers matching your request");
                }
            }

        }

    }
}
