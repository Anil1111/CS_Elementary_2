using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Classes
{
    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
            {
            academicPerformance = "Good pupil";
        }

        public override void Study()
        {
            Console.WriteLine($"Good pupil {Name} is studiing now");
        }
        public override void Read()
        {
            Console.WriteLine($"{Name} is reading now well");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is writing now quick");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} is resting now just a little bit");
        }

    }
}
