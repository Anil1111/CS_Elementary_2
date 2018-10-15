using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Teacher
    {
        string teacherName;


        static void setMark(Enrollee enc1, int numberofExam)
        {
            Random rnd = new Random();
            enc1.Mark[numberofExam] = rnd.Next(0, 100);
 
        }
    }
}
