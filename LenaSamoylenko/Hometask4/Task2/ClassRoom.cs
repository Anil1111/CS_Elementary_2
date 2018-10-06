using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        private List<Pupil> pupilsInClassRoom = new List<Pupil>();
        public ClassRoom(Pupil pupil)
        {
            pupilsInClassRoom.Add(pupil);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2):this(pupil1)
        {
            pupilsInClassRoom.Add(pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3):this(pupil1, pupil2)
        {
            pupilsInClassRoom.Add(pupil3);
        }

        public void Print()
        {
            foreach (Pupil p in pupilsInClassRoom)
            {
                Console.WriteLine(p.FullName);
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n",p.CouldStudy, p.CouldRead, p.CouldWrite, p.CouldRelax);
            }
        }
    }
}
