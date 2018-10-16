using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Enrollee:Exams
    {
        private string enrolleeName;
        double[] mark = new double[3];
        public Enrollee(string enrolleeName, Faculty faculthy):base(faculthy.GroupOfExams.ElementAt(0), faculthy.GroupOfExams.ElementAt(1), faculthy.GroupOfExams.ElementAt(2))
        {
            this.enrolleeName = enrolleeName;
            AllEnrollee.Add(this);
        }

        public double[] Mark { get { return mark; } set { mark = value; } }
        
    }
}
