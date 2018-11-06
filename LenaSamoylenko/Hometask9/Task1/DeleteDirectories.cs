using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Hometask_9
{
    static class  DeleteDirectories
    {
        static private WorkWithDirectories workWithDirectories;
        static private DirectoryInfo directory;

        static DeleteDirectories()
        {
            workWithDirectories = new WorkWithDirectories();
            directory = new DirectoryInfo(workWithDirectories.FullName);
        }

        private static void DeleteFolder()
        {
            Directory.Delete(workWithDirectories.FullName);
        }

        public static void DeleteFolder(string fullName)
        {
            Directory.Delete(fullName);
        }

        public static void DeleteAllFolders()
        {
            
            foreach (var f in directory.GetDirectories())
            {
                DeleteFolder(f.ToString());
            }

           
        }
    }
}
