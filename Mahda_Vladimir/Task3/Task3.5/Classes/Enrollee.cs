using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Enrollee
    {
        private string enrolleeName;
        public int[] grade = new int[3];

        public Enrollee(string enrolleeName/*, int examsCount*/)
        {
            this.enrolleeName = enrolleeName;
            //int[] grade = new int[examsCount];
        }

        public string EnrolleeName { get => enrolleeName; }
        public int[] Grade { get => grade; set => grade = value; }

        public void CheckToFaculty(Faculty faculty)
        {
            faculty.Enrollees.ListEnrollees.Add(this);
        }

        public static double GetAverageEnrolleeGrade(Enrollee enrollee)
        {
            double averageGrade = 0;
            for (int i = 0; i < enrollee.grade.Length; i++)
            {
                averageGrade += enrollee.grade[i];
            }
            return averageGrade / enrollee.grade.Length;
        }

        public void ShowEnrollee()
        {
            Console.WriteLine($"Enrollee {EnrolleeName}");
        }

        public void ShowEnrolleeWithGrades()
        {
            for (int i = 0; i < grade.Length; i++)
            {
                Console.Write($"{Grade[i],0 - 10} | ");
            }
            Console.WriteLine($"{Enrollee.GetAverageEnrolleeGrade(this),0 - 7:N2} | ");
        }
    }
}
