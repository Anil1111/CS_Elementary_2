using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Task2
{
    class LoadBook
    {
        private string fullName;
        public string FullName => fullName;
        private StreamReader streamReaderBook = null;
        public StreamReader StreamReaderBook => streamReaderBook;

        public LoadBook()
        {
            Console.WriteLine("Put full file name, please");
            fullName = Console.ReadLine();
            //fullName = "C:\\Users\\Admin\\Documents\\Books\\Грегори Дэвис Робертс_Шантарам1.txt";
            ReadBook();
        }

        public void ReadBook()
        {
            StreamReader sr = new StreamReader(FullName, System.Text.Encoding.Default);
            streamReaderBook = sr;
        }
    }
}
