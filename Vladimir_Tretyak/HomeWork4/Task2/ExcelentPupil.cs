using System;


namespace HW4Task2
{
    public class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Читает лучше всех,");
        }

        public override void Relax()
        {
            Console.WriteLine("Очень мало отдыхает,");
        }

        public override void Study()
        {
            Console.WriteLine("Отличник,");
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
