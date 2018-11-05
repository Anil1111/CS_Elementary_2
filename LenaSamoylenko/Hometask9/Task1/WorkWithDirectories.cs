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

        public WorkWithDirectories()
        {
            fullName = Directory.GetDirectoryRoot(Environment.CurrentDirectory);
        }
    }
}
