using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Enrollees
    {
       private List<Enrollee> listEnrollees;

        public List<Enrollee> ListEnrollees { get => listEnrollees; }

        public Enrollees()
        {
            listEnrollees = new List<Enrollee>();
        }

        public void ShowEnrollees()
        {
            Console.WriteLine(new string('-', 50));
            if (listEnrollees.Count > 0)
            {
                foreach (var enrollee in listEnrollees)
                {
                    enrollee.ShowEnrollee();
                }
            }
            else
            {
                Console.WriteLine("The enrollee list is empty");
            }
            Console.WriteLine(new string('-', 50));
        }

        public void ShowEnrolleesWithGrades(Exams exams)
        {
            Console.WriteLine(new string('-', 50));
            if (listEnrollees.Count > 0)
            {
                foreach (var enrollee in listEnrollees)
                {
                    Console.WriteLine(new string('`', 50));
                    Console.WriteLine($"enrollee: {enrollee.EnrolleeName} | grades: ");
                    Console.WriteLine($"{exams.ListExams[0].ExamTitle,0 - 10} | {exams.ListExams[1].ExamTitle,0 - 10} | {exams.ListExams[2].ExamTitle,0 - 10} | average |");
                    enrollee.ShowEnrolleeWithGrades();
                }
            }
            else
            {
                Console.WriteLine("The enrollee list is empty");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
