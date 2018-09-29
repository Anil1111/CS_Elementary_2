using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook
{
    public class CContent
    {
        public string Content
        {
            get
            {
                return content;
            }
        }

        private string content = string.Empty;

        public CContent(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Кратрое содержание : {0}", Content);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
