using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Classes
{
    public class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil)
        {
            pupils.Add(pupil);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2) : this(pupil1)
        {
            pupils.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            pupils.Add(pupil3);
        }

        public void AddPupil (Pupil pupil)
        {
            pupils.Add(pupil);
        }

        public void ShowClassRoom()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine(new string ('-', 30));
            }
        }
    }
}
