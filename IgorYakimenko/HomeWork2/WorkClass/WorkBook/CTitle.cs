using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook
{
    public class CTitle
    {
        public string Title
        {
            get
            {
                return title;
            }
        }

        private string title = string.Empty;

        public CTitle(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Заглавие : {0}", Title);            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
