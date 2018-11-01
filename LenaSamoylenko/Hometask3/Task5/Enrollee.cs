using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Enrollee : Exams
    {
        private string enrolleeName;
        private double[] mark = new double[3];
        private string[] teacherName = new string[3];
        private double averageMark;
        private bool inChooseFaculty = false;
        public Enrollee(string enrolleeName, Faculty faculthy) : base(faculthy.GroupOfExams.ElementAt(0), faculthy.GroupOfExams.ElementAt(1), faculthy.GroupOfExams.ElementAt(2))
        {
            this.faculthyName = faculthy.FaculthyName;
            this.enrolleeName = enrolleeName;
            AllEnrollee.Add(this);
        }
        public string EnrolleeName=> enrolleeName;
        public bool InChooseFaculty { get { return inChooseFaculty; } set { inChooseFaculty = value; } }
        public double[] Mark { get { return mark; } set { mark = value; } }
        public string[] TeacherName { get { return teacherName; } set { teacherName = value; } }

        public double AverageMark { get { return averageMark; } set { averageMark = value; } }

        private static double AvaregeMark(int studentNumberInAllEroleeList)
        {
            double result;
            result = AllEnrollee[studentNumberInAllEroleeList].Mark.Average();
            return result;
        }
        static public double CheckToFindAvaregeMark(int studentNumberInAllEroleeList)
        {
            double result = 0;
            if (AllEnrollee[studentNumberInAllEroleeList].TeacherName[0] != null && AllEnrollee[studentNumberInAllEroleeList].TeacherName[1] != null && AllEnrollee[studentNumberInAllEroleeList].TeacherName[2] != null)
            { result = AvaregeMark(studentNumberInAllEroleeList); }
            return result;
        }

    }
}
