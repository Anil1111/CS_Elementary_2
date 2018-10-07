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
        private DateTime yearStartWorking;

        public string FullName => fullName;
        public string Position => position;
        public DateTime YearStartWorking => yearStartWorking;

        public Worker(string fullName, string position, DateTime yearStartWorking)
        {
            this.fullName = fullName;
            this.position = position;
            this.yearStartWorking = yearStartWorking;
  
        }


    }








}
