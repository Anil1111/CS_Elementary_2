using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Content
    {
        public string content;

        public void Show()
        {
            Console.WriteLine("Content: " + content, Console.ForegroundColor = ConsoleColor.DarkBlue);
        }
    }
}
