using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task3
{
    class FindFile:Inizialization
    {
        private DirectoryInfo directoryInfo;
        private FileInfo [] fileInfo;

        public FileInfo [] FileInfo => fileInfo;

        public FindFile():base()
        { }
        public void FindFileOnDisk()
        {
            directoryInfo = new DirectoryInfo(DiskName);
            fileInfo=directoryInfo.GetFiles(FileName);
            //Почему возникает ошибка при входе в системные файлы?? 
            //var fileInfo=directoryInfo.GetFiles(FileName, SearchOption.AllDirectories);
            printFindResult(fileInfo);
        }
        //DirectoryInfo directoryInfo=new DirectoryInfo(this.di)

        private void printFindResult(FileInfo [] fileInfo)
        {
            foreach (var fi in fileInfo)
            {
                Console.WriteLine(fi.Exists);
            }
        }
    }
}
