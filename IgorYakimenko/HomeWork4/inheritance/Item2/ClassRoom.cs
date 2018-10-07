using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class ClassRoom
    {
        public ClassRoom(params Pupil[] pupil)
        {

            try
            {
                Pupil pupil1 = new BadPupil(pupil[0].Fio);
                pupil1.Study();
                pupil1.Write();
                pupil1.Relax();
                pupil1.Read();

                Console.WriteLine(new string('-', 50));
            }
            catch { }

            try
            {
                Pupil pupil2 = new GoodPupil(pupil[1].Fio);
                pupil2.Study();
                pupil2.Write();
                pupil2.Relax();
                pupil2.Read();

                Console.WriteLine(new string('-', 50));
            }
            catch { }

            try
            {
                Pupil pupil3 = new ExcelentPupil(pupil[2].Fio);
                pupil3.Study();
                pupil3.Write();
                pupil3.Relax();
                pupil3.Read();

                Console.WriteLine(new string('-', 50));
            }
            catch { }

            try
            {
                Pupil pupil4 = new BadPupil(pupil[3].Fio);
                pupil4.Study();
                pupil4.Write();
                pupil4.Relax();
                pupil4.Read();
            }
            catch { }


        }

        
    }
}
