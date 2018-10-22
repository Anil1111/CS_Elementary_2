using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Classes
{
    public abstract class Pupil
    {
        private string name;
        protected string academicPerformance = string.Empty;

        public string Name { get => name; }
        public string AcademicPerformance { get => academicPerformance; }

        public Pupil(string name)
        {
            this.name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine($"{Name} is studiing now");
        }
        public virtual void Read()
        {
            Console.WriteLine($"{Name} is reading now");
        }

        public virtual void Write()
        {
            Console.WriteLine($"{Name} is writing now");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"{Name} is resting now");
        }
    }
}
