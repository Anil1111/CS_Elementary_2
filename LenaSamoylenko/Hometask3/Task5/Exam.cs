using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Exam: University
    {
       
        //public string EnrolleeName => enrolleeName;
        public Exam() { }
        public Exam(string ex1) 
        {
            ExamName.Add(ex1);
        }
        
    }
}
