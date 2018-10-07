using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class ExcellentPupil:Pupil
    {
        private readonly string marks = String.Empty;
        public ExcellentPupil()
        {

        }
        public ExcellentPupil(string marks, string name, string surname) : base(name, surname)
        {
            this.marks = "Bad Performance";

        }
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Perfect!Keep it up!");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Perfect!Keep it up!");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Take your time");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Perfect!Keep it up!");
            Console.ResetColor();
        }
        public override void Print()
        {
            ExcellentPupil ep = new ExcellentPupil();
            ep.Study();
            ep.Read();
            ep.Relax();
            ep.Write();
        }
    }
}
