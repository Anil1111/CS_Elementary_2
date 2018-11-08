using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Task2
{
    static class Helper
    {
        private static FileStream fileStream;
        public static FileStream _FileStream => fileStream;

        static Helper()
        {
            fileStream = new FileStream(PutName(),FileMode.OpenOrCreate);
        }

        private static string PutName()
        {
            Console.WriteLine("Put full file name");
            //string fullName = Console.ReadLine();
            string fullName = "C:\\Users\\Public\\Documents\\txt2.txt";
            return fullName;
        }
    }
}
