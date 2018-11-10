using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.IO;

namespace Task4.IsolatedStorage
{
    class CreateStorage:HelpClass
    {

        public CreateStorage()
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            userStream = new IsolatedStorageFileStream("UserSettings_Task4_LenaS.set", FileMode.Create, userStorage);
        }
    }
}
