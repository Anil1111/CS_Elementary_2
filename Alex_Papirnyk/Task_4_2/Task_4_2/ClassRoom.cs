using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class ClassRoom
    {
        public ClassRoom()
        {

        }
        private List<Pupil> pupilsInClassRoom = new List<Pupil>();
        public ClassRoom(Pupil pupil)
        {
            pupilsInClassRoom.Add(pupil);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2) : this(pupil1)
        {
            pupilsInClassRoom.Add(pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            pupilsInClassRoom.Add(pupil3);
        }
        /// <summary>
        /// на случай, если понадобиться добавить еще пару учеников
        /// </summary>
        /// <param name="pupil"></param>
        public void Addpups(Pupil pupil)
        {
            pupilsInClassRoom.Add(pupil);
        }
        public void Show()
        {
            foreach(Pupil p in pupilsInClassRoom)
            {
                Console.WriteLine("{0} {1}", p.Name, p.Surname);
                p.Study();
                p.Read();
                p.Relax();
                p.Write();
                Console.WriteLine(new string('-',40));
            }
        }
      
    }
}
