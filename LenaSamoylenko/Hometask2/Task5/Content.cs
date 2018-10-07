using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Content
    {
        private string content;
        public string contentProperties=>content;
        public Content(string bookContent)
        {
            this.content = bookContent;
        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Content:{0}\n",contentProperties);
         }
    }
}



