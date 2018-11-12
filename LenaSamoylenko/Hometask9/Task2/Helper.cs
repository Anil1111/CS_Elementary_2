using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Task2
{
    public abstract class Helper
    {
        private FileStream fileStream;
        public FileStream _FileStream => fileStream;
        private string fullFileName;
        public string FullFileName => fullFileName;

        private Helper()
        {
            fullFileName = PutName();
        }

        public Helper(FileMode mode) : this()
        {
            fileStream = new FileStream(FullFileName, mode);
        }

        private string PutName()
        {
            Console.WriteLine("Put full file name");
            string fullName = Console.ReadLine();
            //string fullName = "C:\\Users\\Public\\Documents\\txt2.txt";
            return fullName;
        }
    }
}
