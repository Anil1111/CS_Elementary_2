using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Exams : Exam
    {
        string[] groupOfExams = new string[3];
        protected string faculthyName;
        public string FaculthyName { get { return faculthyName; } }
        public string[] GroupOfExams => groupOfExams;
        public Exams(string ex1, string ex2, string ex3) 
        {
            groupOfExams[0] = ex1;
            groupOfExams[1] = ex2;
            groupOfExams[2] = ex3;
            //ExamGroup.Add(groupOfExams);
        }
    }
}
