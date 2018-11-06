using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hometask_9
{
    class WorkWithDirectories
    {
        private string fullName;
        public string FullName => fullName;

        private DirectoryInfo directory;
        public DirectoryInfo Directory => directory;


        public WorkWithDirectories()
        {
            //для работы на диске С
            //fullName = Directory.GetDirectoryRoot(Environment.CurrentDirectory);
            fullName = Environment.CurrentDirectory;
            directory = new DirectoryInfo(FullName);
        }
    }
}
