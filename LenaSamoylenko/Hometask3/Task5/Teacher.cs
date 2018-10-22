using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Teacher : University
    {
        private string teacherName;
        public string TeacherName => teacherName;
        public Teacher(string teacherName)
        {
            this.teacherName = teacherName;
        }

        public void setMark(Enrollee enc1, int numberofExam)
        {
            int indexLocalVar = AllEnrollee.IndexOf(enc1);
            //вот тут трабл
            Random rand = new Random();
            enc1.Mark[numberofExam] = rand.Next(50,100);
            enc1.TeacherName[numberofExam] = TeacherName;

            SetAvarageMark(enc1, indexLocalVar);
            
        }

        private void SetAvarageMark(Enrollee enc1, int indexLocalVar)
        {
            enc1.AverageMark = Enrollee.CheckToFindAvaregeMark(indexLocalVar);
            AllEnrollee[indexLocalVar] = enc1;
        }

    }
}
