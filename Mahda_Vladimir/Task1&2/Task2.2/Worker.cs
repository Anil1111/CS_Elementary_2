using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Worker
    {
        private string workerFIO;
        private string workerPosition;
        private int workerYearOfEmployment;

        public string WorkerFIO { get => workerFIO; }
        public string WorkerPosition { get => workerPosition; }
        public int YearOfEmployment { get => workerYearOfEmployment; }

        public void Initializer(string workerFIO, string workerPosition, int workerYearOfEmployment)
        {
            this.workerFIO = workerFIO;
            this.workerPosition = workerPosition;
            this.workerYearOfEmployment = workerYearOfEmployment;
        }

        public Worker(string workerFIO, string workerPosition, int workerYearOfEmployment)
        {
            Initializer(workerFIO, workerPosition, workerYearOfEmployment);
        }

        public void showWorker()
        {
            Console.WriteLine($"FIO: {WorkerFIO, 0 -15}| position: {WorkerPosition, 0 -15}| year: {YearOfEmployment, 0 -4}");
        }

    }
}
