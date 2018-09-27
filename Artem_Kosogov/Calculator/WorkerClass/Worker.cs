using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class Worker
    {
        private string workerSurnameAndInitials;
        private string workerPosition;
        private int workerYearOfEmployment;

        public string WorkerSurnameAndInitials
        {
            get
            {
                return workerSurnameAndInitials;
            }
            set
            {
                workerSurnameAndInitials = value;
            }
        }

        public string WorkerPosition
        {
            get
            {
                return workerPosition;
            }
            set
            {
                workerPosition = value;
            }
        }

        public int WorkerYearOfEmployment
        {
            get
            {
                return workerYearOfEmployment;
            }
            set
            {
                workerYearOfEmployment = value;
            }
        }
        public Worker()
        {
            WorkerSurnameAndInitials = "Default worker surname and initials";
            WorkerPosition = "Default worker position";
            WorkerYearOfEmployment = 0000;
        }

        public Worker(string surnameAndInitials, string workerPosition, int yearOfEmployment)
        {
            WorkerSurnameAndInitials = surnameAndInitials;
            WorkerPosition = workerPosition;
            WorkerYearOfEmployment = yearOfEmployment;
        }

        public override string ToString()
        {
            return string.Format("Worker's surname and initials " + this.WorkerSurnameAndInitials + " Worker's position " + this.WorkerPosition + " Year of worker's employment " + this.WorkerYearOfEmployment);
        }
    }
}
