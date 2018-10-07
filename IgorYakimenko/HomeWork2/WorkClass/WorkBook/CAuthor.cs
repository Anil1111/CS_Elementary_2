using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook
{
    public class CAuthor
    {
        public string Author
        {
            get
            {
                return author;
            }
        }

        private string author = string.Empty;

        public CAuthor(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Автор : {0}", Author);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
