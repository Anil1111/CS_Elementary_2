using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Prise
    {
        private string name;
        private string shop;
        private double cash;

        public string Name { get => name; }
        public string Shop { get => shop; }
        public double Cash { get => cash; }
        public Prise()
        {

        }
        public Prise(string name, string shop, double cash)
        {
            this.name = name;
            this.shop = shop;
            this.cash = cash;

        }
    }
}
