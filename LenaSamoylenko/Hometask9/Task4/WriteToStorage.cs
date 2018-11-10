using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.IsolatedStorage;
using System.IO;

namespace Task4
{
    class WriteToStorage
    {
        public WriteToStorage(UseStorage useStorage, string fileName)
        {
            StreamWriter streamWriter = new StreamWriter(useStorage.UserStream);
            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                streamWriter.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
            streamWriter.Close();
        }



    }
}
