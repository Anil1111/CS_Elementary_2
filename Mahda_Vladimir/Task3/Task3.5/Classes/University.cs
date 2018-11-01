using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class University
    {
        private string universityTitle;
        private List<Faculty> listFaculties;

        public University(string universityTitle, List<Faculty> listFaculties)
        {
            this.universityTitle = universityTitle;
            this.listFaculties = listFaculties;
        }

        public string UniversityTitle { get => universityTitle; }
        public List<Faculty> ListFaculties { get => listFaculties; }

        public static void ShowListEnrolledStudents(Faculty faculty, double passingScore)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"List enrollees (passing score = {passingScore})");
            foreach (Enrollee enrollee in faculty.Enrollees.ListEnrollees)
            {
                Console.WriteLine(new string('-', 50));
                if (Enrollee.GetAverageEnrolleeGrade(enrollee) >= passingScore)
                {
                    Console.WriteLine($"Enrollee {enrollee.EnrolleeName} ENROLLED in university on faculty {faculty.FacultyTitle} ({Enrollee.GetAverageEnrolleeGrade(enrollee),0 - 5:N2})");
                }
                else
                {
                    Console.WriteLine($"Enrollee {enrollee.EnrolleeName} NOT enrolled in university on faculty {faculty.FacultyTitle} ({Enrollee.GetAverageEnrolleeGrade(enrollee),0 - 5:N2})");
                }
            }
            Console.WriteLine(new string('-', 50));
        }

        public void ShowUniversity()
        {
            Console.WriteLine(new string('#', 50));
            Console.WriteLine($"University {UniversityTitle}");
            if (listFaculties.Count > 0)
            {
                foreach (Faculty faculty in listFaculties)
                {
                    faculty.ShowFaculty();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The faculty list is empty");
            }
            Console.WriteLine(new string('#', 50));
        }
    }
}
