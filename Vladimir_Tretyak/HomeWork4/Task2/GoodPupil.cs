using System;


namespace HW4Task2
{
    public class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Быстро читает,");
        }

        public override void Relax()
        {
            Console.WriteLine("Активно отдыхает,");
        }

        public override void Study()
        {
            Console.WriteLine("Хорошист,");
        }
    
        public override void Write()
        {
            Console.WriteLine("Пишет без ошибок.");
        }
        public override void print()
        {         
            Read();
            Relax();
            Study();
            Write();
        }
    }
}
