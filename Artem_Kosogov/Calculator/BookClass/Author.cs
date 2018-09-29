using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Author
    {
        public string author;

        public void Show()
        {
            Console.WriteLine("Content: " + author, Console.ForegroundColor = ConsoleColor.Yellow);
        }
    }
}
