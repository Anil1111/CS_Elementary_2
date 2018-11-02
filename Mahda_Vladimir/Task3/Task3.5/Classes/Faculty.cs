using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Faculty
    {
        private string facultyTitle;
        private Exams exams;
        private Enrollees enrollees;
        private Teacher teacher;

        public Faculty(string facultyTitle, Exams exams, Enrollees enrollees, Teacher teacher)
        {
            this.facultyTitle = facultyTitle;
            this.exams = exams;
            this.enrollees = enrollees;
            this.teacher = teacher;
        }

        public string FacultyTitle { get => facultyTitle; }
        public Exams Exams { get => exams; }
        public Enrollees Enrollees { get => enrollees; }
        public Teacher Teacher { get => teacher; }

        public void ShowFaculty()
        {
            Console.WriteLine($"Faculty: {FacultyTitle}");
            Console.WriteLine($"Exams");
            exams.ShowExams();
            Console.WriteLine($"Enrollees");
            enrollees.ShowEnrollees();
            Console.WriteLine($"Teacher: {Teacher.TeacherName}");
        }
    }
}
