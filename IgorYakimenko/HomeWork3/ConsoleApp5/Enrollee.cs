using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Enrollee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Faculty { get; set; }
        public Int16 Grade { get; set; }

        public Enrollee(string surname, string name, string middleName, string faculty, Int16 grade)
        {
            Inicialize(surname, name, middleName, faculty, grade);
        }

        private void Inicialize(string surname, string name, string middleName, string faculty, Int16 grade)
        {
            this.Surname = surname;
            this.Name = name;
            this.MiddleName = middleName;
            this.Faculty = faculty;
            this.Grade = grade;
        }
    }
}
