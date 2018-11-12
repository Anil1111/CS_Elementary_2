using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    public class AddData : Helper
    {
        public AddData(FileMode mode) : base(mode)
        {
            AddDataToFile();

        }

        private void AddDataToFile()
        {
            StreamWriter writer = new StreamWriter(_FileStream);
            Console.WriteLine("Put your text");
            writer.Write(Console.ReadLine());
            writer.Close();
        }
    }
}
