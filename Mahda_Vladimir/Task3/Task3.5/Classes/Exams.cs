using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Exams
    {
        List<Exam> listExams;

        public Exams()
        {
            listExams = new List<Exam>();
        }

        public Exams (Exam exam1, Exam exam2, Exam exam3)
        {
            listExams = new List<Exam>
            {
                exam1,
                exam2,
                exam3
            };

        }

        public List<Exam> ListExams { get => listExams; }

        public void ShowExams()
        {
            Console.WriteLine(new string('*', 50));
            if (listExams.Count > 0)
            {
                foreach (Exam exam in listExams)
                {
                    exam.ShowExam();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The exams list is empty");
            }          
            Console.WriteLine(new string('*', 50));
        }
    }
}
