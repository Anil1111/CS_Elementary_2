using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Title
    {
        public string title;

        public void Show()
        {
            Console.WriteLine("Content: " + title, Console.ForegroundColor = ConsoleColor.Red);
        }
    }
}
