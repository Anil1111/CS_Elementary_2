using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class ClassRoom
    {

        private Pupil currentPupil;
        private List<GoodPupil> gPupilsList;
        private List<SpecialPupil> cPupilsList;

        //public string GetGInfo(GoodPupil gPupil){ return}

        public ClassRoom()
        {            
            gPupilsList = new List<GoodPupil>();
            cPupilsList = new List<SpecialPupil>();
        }

        public void ClassRoomInfo()
        {


            foreach (GoodPupil goo in gPupilsList)
            {
                Console.WriteLine(goo.Description());
            }
            foreach (SpecialPupil spec in cPupilsList)
            {
                Console.WriteLine(spec.Description());
            }


        }

        public void addPupil(Pupil p)
        {
            currentPupil = p;
        }

        private void AddIdentifyedPupil(GoodPupil g)
        {
            gPupilsList.Add(g);
        }
        private void AddIdentifyedPupil(SpecialPupil g)
        {
            cPupilsList.Add(g);
        }


        public void Identify()/////////////чево блять !!!
        {
            if (currentPupil.coef > 3)
            {
                AddIdentifyedPupil(new GoodPupil(currentPupil.Name, currentPupil.Savvy, currentPupil.MentalCondition, currentPupil.Cheerfulnes, currentPupil.PhysicalCondition, currentPupil.SelfEsteem));

            }
            else
            {
                AddIdentifyedPupil(new SpecialPupil(currentPupil.Name, currentPupil.Savvy, currentPupil.MentalCondition, currentPupil.Cheerfulnes, currentPupil.PhysicalCondition, currentPupil.SelfEsteem));
            }
        }




    }
}
