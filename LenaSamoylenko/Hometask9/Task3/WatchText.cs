using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task3
{
    class WatchText
    {
        FindFile findFile;
        public FindFile FindFile => findFile;

        private FileStream[] fileStream;

        private FileStream mainFileStream;
        internal FileStream MainFileStream => mainFileStream;

        public WatchText(FindFile ff)
        {
            findFile = ff;
            fileStream = new FileStream[FindFile.FileInfo.Length];
            for (int i = 0; i < fileStream.Length; i++)
            {
                fileStream[i] = new FileStream(FindFile.FileInfo[i].FullName, FileMode.Open);
            }

        }



        public void ChooseFileAndPrint()
        {
            PrintFileList();
            Console.WriteLine("Put serial file number");
            int serialNumber = Convert.ToInt32(Console.ReadLine());
            PrintDataFromFile(serialNumber);
        }

        private void PrintDataFromFile(int serialNumber)
        {
            mainFileStream = fileStream[serialNumber];
            var streamReader = new StreamReader(mainFileStream, Encoding.Default);
            Console.WriteLine(streamReader.ReadToEnd());
        }

        private void PrintFileList()
        {
            Console.WriteLine("There are all files:");
            int localVar = 0;
            foreach (var f in fileStream)
            {
                Console.WriteLine("{0}:\t{1}", localVar, FindFile.FileInfo[localVar].FullName);
                localVar++;
            }
        }
    }
}
