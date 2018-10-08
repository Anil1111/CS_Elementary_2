using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class ExcelentPupil : Pupil
    {

        public ExcelentPupil(string fio)
            : base(fio)
        { }

        public override void Study()
        {
            Console.WriteLine("Студент {0} отлично учится", base.Fio);
        }

        public override void Read()
        {
            Console.WriteLine("Студнент {0} отлично читает", base.Fio);
        }

        public override void Write()
        {
            Console.WriteLine("Студнент {0} отлично пишет", base.Fio);
        }

        public override void Relax()
        {
            Console.WriteLine("Студнент {0} отлично отдыхает", base.Fio);
        }

    }
}
