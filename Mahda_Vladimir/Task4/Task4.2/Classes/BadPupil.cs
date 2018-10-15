using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Classes
{

    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
            {
            academicPerformance = "Bad pupil";
        }

        public override void Study()
        {
            Console.WriteLine($"Bad pupil {Name} is not studying right now");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} is reading now very bad");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is writing now very slow");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} is resting all the time");
        }

    }
}

