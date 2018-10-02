using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Pupil
    {

        protected string couldStudy;
        protected string couldRead;
        protected string couldWrite;
        protected string couldRelax;
        protected string fullName;
        public string CouldStudy => couldStudy;
        public string CouldRead => couldRead;
        public string CouldWrite => couldWrite;
        public string CouldRelax => couldRelax;
        public string FullName => fullName;
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
        public Pupil(string name)
        {
            fullName = name;
            Study();
            Read();
            Write();
            Relax();
        }
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name) { }
        public override void Study()
        {
            couldStudy = "He is one of the best pupil in group";
        }
        public override void Read()
        {
            couldRead = "He could read very well";
        }
        public override void Write()
        {
            couldWrite = "His writings are excelent";
        }
        public override void Relax()
        {
            couldRelax = "He couldn`t relax";
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }
        public override void Study()
        {
            couldStudy = "He is good pupil";
        }
        public override void Read()
        {
            couldRead = "He could read better";
        }
        public override void Write()
        {
            couldWrite = "His writings are good";
        }
        public override void Relax()
        {
            couldRelax = "He prefer spend time with friends";
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override void Study()
        {
            couldStudy = "He is bad pupil";
        }
        public override void Read()
        {
            couldRead = "He couldn'n read at all";
        }
        public override void Write()
        {
            couldWrite = "He couldn'n write at all";
        }
        public override void Relax()
        {
            couldRelax = "He have bad behaviors";
        }
    }
}
