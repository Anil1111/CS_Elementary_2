using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5.Classes
{
    class Title
    {
        private string titleOfBook;

        public string TitleOfBook { get => titleOfBook; set => titleOfBook = value; }

        public void showTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{titleOfBook}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Title(string titleOfBook)
        {
            this.titleOfBook = titleOfBook;
        }
    }
}
