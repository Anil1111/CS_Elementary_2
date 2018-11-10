using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFile findFile = new FindFile();
            findFile.FindFileOnDisk();

            WatchText watchText = new WatchText(findFile);
            watchText.ChooseFileAndPrint();

            Archiving archiving = new Archiving(watchText);
            archiving.ArchivingFile();
            Console.ReadKey();
        }
    }
}
