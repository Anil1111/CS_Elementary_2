using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class GoodPupil : Pupil
    {

        public GoodPupil(string name, int savvy, int mentalCondition, int cheerfulnes, int physicalCondition, int selfEsteem) : base(name, savvy, mentalCondition, cheerfulnes, physicalCondition, selfEsteem)
        {

        }

        public override string Description()
        {
            return $"{Info}\nЭто хороший ученик, баланс показателей уравнивается самооценкой\n";
        }
    }
}
