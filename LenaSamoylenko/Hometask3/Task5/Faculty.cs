using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Faculty:Exams
    {
        private double averageMarkInFaculty;
        public double AverageMarkInFaculty => averageMarkInFaculty;
        public Faculty(string ex1, string ex2, string ex3, string faculthyName) :base(ex1, ex2, ex3)
        {
            this.faculthyName = faculthyName;
            Faculty.Add(this);
        }
        public void AddEtalonMarkForFaculty(double etalonMark)
        {
            averageMarkInFaculty = etalonMark;
        }
    }
}
