using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Inizialization
    {
        private string fileName;
        private string diskName;

        public string FileName => fileName;
        public string DiskName => diskName;
        public Inizialization()
        {
            fileName = PutData("Put file name");
            diskName = PutData("Put disk name");
        }

        private string PutData(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            return result;
        }
    }
}
