using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;

namespace Task4.IsolatedStorage
{
    abstract class HelpClass
    {
        protected IsolatedStorageFileStream userStream;
        public IsolatedStorageFileStream UserStream => userStream;
    }
}
