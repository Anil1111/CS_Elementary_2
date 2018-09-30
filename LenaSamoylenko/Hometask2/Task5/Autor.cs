using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Autor
    {
        private string autor;
        public string autorProperties=>autor;
        public Autor(string bookAutor)
        {
            this.autor = bookAutor;
        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Autor:{0}\n", autorProperties);
        }
    }
}
