using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class BadPupil:Pupil
    {

        public BadPupil(string fio)
            : base(fio)
        { }

        public override void Study()
        {
            Console.WriteLine("Студент {0} плохо учится", base.Fio);
        }

        public override void Read()
        {
            Console.WriteLine("Студнент {0} плохо читает", base.Fio);
        }

        public override void Write()
        {
            Console.WriteLine("Студнент {0} плохо пишет", base.Fio);
        }

        public override void Relax()
        {
            Console.WriteLine("Студнент {0} плохо отдыхает", base.Fio);
        }
    }
}
