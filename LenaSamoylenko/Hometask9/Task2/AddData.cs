using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    class AddData
    {
        public void AddDataToFile()
        {
            StreamWriter writer = new StreamWriter(Helper._FileStream);
            Console.WriteLine("Put your text");
            writer.WriteLine("gfgf");
            //writer.NewLine = Console.ReadLine();
            writer.Close();
        }
    }
}
