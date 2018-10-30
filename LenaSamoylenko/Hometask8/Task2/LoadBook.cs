using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    class LoadBook
    {
        private string fullName;
        public LoadBook()
        {
            Console.WriteLine("Put full file name, please");
            fullName = Console.ReadLine();
        }
        FileStream file = new FileStream(fullName, 3);
    }
}
