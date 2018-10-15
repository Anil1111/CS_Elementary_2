using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class University
    {
        private List<string> examName = new List<string>();
        public List<string> ExamName { get { return examName; } set { examName = value; } }

        //private List<Exams> examGroup = new List<Exams>();
        //public List<Exams> ExamGroup { get { return examGroup; } set { examGroup = value; } }

        static private List<Faculty> faculty = new List<Faculty>();
        public List<Faculty> Faculty { get { return faculty; } set { faculty = value; } }

        static private List<Enrollee> allEnrollee = new List<Enrollee>();
        public static List<Enrollee> AllEnrollee { get { return allEnrollee; } set { allEnrollee = value; } }


    }
}
