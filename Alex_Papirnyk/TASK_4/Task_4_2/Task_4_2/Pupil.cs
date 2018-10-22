using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class Pupil
    {
        private string name;
        private string surname;

        public string Name { get => name; }
        public string Surname { get => surname; }

        public Pupil()
        {

        }
        public Pupil(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }
        public virtual void Study()
        {
            Console.WriteLine("Common student");
        }
        public virtual void Read()
        {
            Console.WriteLine("Common student");
        }
        public virtual void Write()
        {
            Console.WriteLine("Common student");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Common student");
        }
        public virtual void Print()
        {
            Pupil p = new Pupil();
            p.Study();
            p.Read();
            p.Relax();
            p.Write();
        }
    }
}
