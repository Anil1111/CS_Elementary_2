using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Faculty:Exams
    {
        private string faculthyName;
        public string FaculthyName { get { return faculthyName; } }
        public Faculty(string ex1, string ex2, string ex3, string faculthyName) :base(ex1, ex2, ex3)
        {
            this.faculthyName = faculthyName;
            Faculty.Add(this);
        }
    }
}
