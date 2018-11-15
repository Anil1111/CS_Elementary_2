using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class SpecialPupil : Pupil
    {

        public SpecialPupil(string name, int savvy, int mentalCondition, int cheerfulnes, int physicalCondition, int selfEsteem) : base(name, savvy, mentalCondition, cheerfulnes, physicalCondition, selfEsteem)
        {

        }

        public override string Description()
        {
            return $"{Info}\nСамый обычный, номальный, хороший ученик. Не без изъянов. А у кого их нет\n";
        }
    }
}
