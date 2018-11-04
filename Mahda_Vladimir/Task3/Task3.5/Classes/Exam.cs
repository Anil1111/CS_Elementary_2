using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5.Classes
{
    public class Exam
    {
        private string examTitle;

        public Exam(string examTitle)
        {
            this.examTitle = examTitle;
        }

        public string ExamTitle { get => examTitle; }

        public void ShowExam()
        {
            Console.Write($"exam: {ExamTitle} | ");
        }

    }
}
