using System;


namespace HW4Task2
{
    public class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Плохо читает,");
        }

        public override void Relax()
        {
            Console.WriteLine("Тратит время впустую,");
        }

        public override void Study()
        {
            Console.WriteLine("Троечник,");
        }

        public override void Write()
        {
            Console.WriteLine("Пишет с ошибками.");
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
