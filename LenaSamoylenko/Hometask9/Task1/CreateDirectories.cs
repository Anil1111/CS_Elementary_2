using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Hometask_9
{
    class CreateDirectories
    {
        static private WorkWithDirectories workWithDirectories;
        

        static CreateDirectories()
        {
            workWithDirectories = new WorkWithDirectories();
        }

        private static void AddFolder(int i)
        {
            workWithDirectories.Directory.CreateSubdirectory(i.ToString());
        }

        
        public static void AddFolders(int folderCount)
        {

            for (int i = 1; i <= folderCount; i++)
            {
                AddFolder(i);
            }
        }
    }
}
