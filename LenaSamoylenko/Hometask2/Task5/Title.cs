using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Title
    {
        private string title = null;
        public string titleProperties
        {
            get { return title; }
            set { title = value; }

        }

        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Title:{0}\n",titleProperties);
        }
    }
}
