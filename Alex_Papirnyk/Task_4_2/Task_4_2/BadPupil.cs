using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class BadPupil:Pupil
    {
        private readonly string marks =String.Empty;
        public BadPupil()
        {

        }
        public BadPupil(string marks,string name, string surname):base(name,surname)
        {
            this.marks = "Bad Performance";
            
        }
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You should study more");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You should read more books");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You should relax less");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You practise more in writing");
            Console.ResetColor();
        }
        public override void Print()
        {
            BadPupil bp = new BadPupil();
            bp.Study();
            bp.Read();
            bp.Relax();
            bp.Write();
        }
    }
}
