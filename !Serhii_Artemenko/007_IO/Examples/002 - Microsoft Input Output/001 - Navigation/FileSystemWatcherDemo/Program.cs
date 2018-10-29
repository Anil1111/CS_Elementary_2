using System;
using System.Diagnostics;
using System.IO;

// Отслеживание изменений в системе.

namespace FileSystemWatcherDemo
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя и сосредоточение его внимания на системном диске.
            var watcher = new FileSystemWatcher { Path = @"c:\bin" };

            

            // Зарегистрировать обработчики событий.
            watcher.Created += new FileSystemEventHandler(WatcherCreated);
            watcher.Deleted += new FileSystemEventHandler(WatcherDeleted);
            watcher.Renamed += Watcher_Renamed;
            watcher.Error += Watcher_Error;

            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            // Delay.
            var change = watcher.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(change.ChangeType);

            Console.ReadLine();
        }

        private static void Watcher_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Directory error");
        }

        private static void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Directory renamed({0}): {1}", e.ChangeType, e.FullPath);
        }

        // Обработчик события.
        static void WatcherDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory Deleted({0}): {1}", e.ChangeType, e.FullPath);
        }

        static void WatcherCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory Created({0}): {1}", e.ChangeType, e.FullPath);
        }
    }
}
