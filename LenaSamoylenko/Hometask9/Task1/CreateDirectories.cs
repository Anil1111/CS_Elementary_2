using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Hometask_9
{
    class CreateDirectories
    {
        static private WorkWithDirectories workWithDirectories;
        static private DirectoryInfo directory;

        static CreateDirectories()
        {
            workWithDirectories = new WorkWithDirectories();
        }

        private static void AddFolder(int i)
        {
            directory= new DirectoryInfo(workWithDirectories.FullName);
            directory.CreateSubdirectory(i.ToString());
        }

        public static void AddFolder(string fullName)
        {
            directory = new DirectoryInfo(workWithDirectories.FullName);
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
