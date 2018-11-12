using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.IO;


namespace Task4.IsolatedStorage
{
    class UseStorage : HelpClass
    {
        public UseStorage(string storage)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly | IsolatedStorageScope.User, null, null);
            userStream = new IsolatedStorageFileStream(storage, FileMode.Append, isoStore);
        }
    }
}
