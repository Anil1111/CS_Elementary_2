using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5.Classes
{
    class Content
    {
        private string contentOfBook;

        public string ContentOfBook { get => contentOfBook; set => contentOfBook = value; }

        public void showContent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{contentOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Content(string contentOfBook)
        {
            this.contentOfBook = contentOfBook;
        }
    }
}
