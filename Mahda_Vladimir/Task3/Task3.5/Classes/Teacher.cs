using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Teacher
    {
        private string teacherName;

        public Teacher(string teacherName)
        {
            this.teacherName = teacherName;
        }

        public string TeacherName { get => teacherName; }

        public void ShowTeacher()
        {
            Console.WriteLine($"Teacher: {TeacherName}");
        }

        //для упрощения преподаватель выставляет оценки сразу по всем экзаменам 
        //всем абитуриентам
        public void SetEnrolleesGrades(Faculty faculty)
        {
            Random random = new Random();
            foreach (Enrollee enrollee in faculty.Enrollees.ListEnrollees)
            {
                for (int i = 0; i < enrollee.grade.Length; i++)
                {
                    enrollee.Grade[i] = random.Next(1, 101);
                }
            }
        }
    }
}
