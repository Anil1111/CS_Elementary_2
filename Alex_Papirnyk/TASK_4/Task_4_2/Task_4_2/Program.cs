using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pupil goodp = new GoodPupil("Good marks", "Alex", "Papirnyk");
            Pupil excellentp = new ExcellentPupil("Amazing marks", "Gabe", "Newell");
            Pupil badpupil = new BadPupil("Bad marks", "Ivan", "Ivanov");
            Pupil badpupil1 = new BadPupil("Bad marks", "Ivanov", "Ivanko");
            ClassRoom classRoom = new ClassRoom(goodp, excellentp, badpupil);
            classRoom.Addpups(badpupil1);
            classRoom.Show();
            Console.ReadLine();

        }
    }
}
