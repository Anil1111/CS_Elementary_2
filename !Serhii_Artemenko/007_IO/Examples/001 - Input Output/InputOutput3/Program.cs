using System;
using System.IO;
using System.Threading;

// Создание директорий.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {            
            var directory = new DirectoryInfo(@"c:\bin");
            Console.WriteLine(directory.FullName);
            // Создание в TESTDIR новых подкаталогов.
            if (directory.Exists)
            {
                // Создаем D:\TESTDIR\SUBDIR.
                directory.CreateSubdirectory("SUBDIR");

                // Создаем D:\TESTDIR\MyDir\SubMyDir.
                directory.CreateSubdirectory(@"MyDir\SubMyDir");
                var directory1 = new DirectoryInfo(@"c:\bin\MyDir\SubMyDir");
                Console.WriteLine(directory1.CreationTime);
                directory.CreateSubdirectory(@"MyDir\SubMyDir");
                Thread.Sleep(5000);
                Console.WriteLine(directory1.CreationTime);
                Console.WriteLine("Директории созданы.");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
