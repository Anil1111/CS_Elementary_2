using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string fio)
            : base(fio)
        { }

        public override void Study()
        {
            Console.WriteLine("Студент {0} хорошо учится", base.Fio);
        }

        public override void Read()
        {
            Console.WriteLine("Студнент {0} хорошо читает", base.Fio);
        }

        public override void Write()
        {
            Console.WriteLine("Студнент {0} хорошо пишет", base.Fio);
        }

        public override void Relax()
        {
            Console.WriteLine("Студнент {0} хорошо отдыхает", base.Fio);
        }
    }
}
