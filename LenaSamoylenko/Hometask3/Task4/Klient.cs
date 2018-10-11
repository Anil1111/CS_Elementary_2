using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Klient
    {
        private string klientName;
        private double klientCount;
        public string KlientName => klientName;
        public double KlientCount { get; set; }
        public Klient(string klientName, double klientCount)
        {
            this.klientName = klientName;
            this.klientCount = klientCount;
        }

       
    }
}
