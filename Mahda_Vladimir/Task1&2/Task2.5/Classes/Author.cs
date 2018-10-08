using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5.Classes
{
    class Author
    {
        private string authorOfBook;

        public string AuthorOfBook { get => authorOfBook; set => authorOfBook = value; }

        public void ShowAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{AuthorOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Author(string authorOfBook)
        {
            this.authorOfBook = authorOfBook;
        }
    }
}
