using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Classes
{
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base (name)
        {
            academicPerformance = "Excelent pupil";
        }

        public override void Study()
        {
            Console.WriteLine($"Excelent pupil {Name} is studiing now");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} is reading now very well");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is writing now very quick");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} can not resting now");
        }
    }
}
