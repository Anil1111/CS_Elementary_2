using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    public class ReadData : Helper
    {
        public ReadData(FileMode mode) : base(mode)
        {
            PrintConsole();
        }

        public void PrintConsole()
        {
            StreamReader reader = new StreamReader(_FileStream, Encoding.Default);
            if (!reader.EndOfStream)
            {
                var lines = reader.ReadToEnd();
                Console.WriteLine(lines);
            }
            reader.Close();
        }
    }
}
