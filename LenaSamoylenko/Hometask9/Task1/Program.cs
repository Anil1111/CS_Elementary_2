using System;


//Создайте на диске 100 директорий с именами от Folder_0 до Folder_99, затем удалите их

namespace Hometask_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            CreateDirectories.AddFolders(5);
            DeleteDirectories.DeleteAllFolders();
            Console.ReadKey();

        }
    }
}
