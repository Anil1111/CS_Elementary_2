using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class GoodPupil:Pupil
    {
        private readonly string marks = String.Empty;
        public GoodPupil()
        {

        }
        public GoodPupil(string marks, string name, string surname) : base(name, surname)
        {
            this.marks = "Bad Performance";

        }
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You should study a little bit more");
            Console.ResetColor();
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You should read a little bit more books");
            Console.ResetColor();
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Take your time");
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You practise a little bit more in writing");
            Console.ResetColor();
        }
        public override void Print()
        {
            GoodPupil gp = new GoodPupil();
           
            gp.Study();
            gp.Read();
            gp.Relax();
            gp.Write();
        }
    }
}
