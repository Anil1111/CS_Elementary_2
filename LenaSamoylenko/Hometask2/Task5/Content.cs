using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Content
    {
        private string content=null;
        public string contentProperties
        {
            get { return content; }
            set {content = value; }

        }
        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Content:{0}\n",contentProperties);
         }
    }
}



