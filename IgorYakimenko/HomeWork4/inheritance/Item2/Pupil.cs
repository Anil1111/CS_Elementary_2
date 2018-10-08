using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class Pupil
    {
        public string Fio { get; set; }

        public Pupil(string fio)
        {
            this.Fio = fio;
        }

        public virtual void Study()
        {
            //Console.WriteLine("Студент учится");
        }

        public virtual void Read()
        {
            //Console.WriteLine("Студнент читает");
        }
     
        public virtual void Write()
        {
            //Console.WriteLine("Студнент пишет");
        }
        
        public virtual void Relax()
        {
           // Console.WriteLine("Студнент отдыхает");
        }
    }

  
}
