using System.Collections.Generic;


namespace HW4Task2
{
    class ClassRoom
    {
        public List<Pupil> pupils;    

        public ClassRoom(Pupil newPupil_1,Pupil newPupil_2)
        {
            pupils = new List<Pupil>();
            pupils.Add(newPupil_1);
            pupils.Add(newPupil_2);
        }
        public ClassRoom(Pupil newPupil_1, Pupil newPupil_2,Pupil newPupil_3)
        {
            pupils = new List<Pupil>();
            pupils.Add(newPupil_1);
            pupils.Add(newPupil_2);
            pupils.Add(newPupil_3);
        }

        public void inputData(Pupil pupil)
        {
            pupils.Add(pupil);
        }
    }
}
