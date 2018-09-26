using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Autor
    {
        private string autor = null;
        public string autorProperties
        {
            get { return autor; }
            set { autor = value; }
        }

        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Autor:{0}\n", autorProperties);
        }
    }
}
