using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Task2
{
    static class FindAndReplaceManager
    {
        private static string partOfText;
        static FindAndReplaceManager()
        {
            partOfText = GetPartOfText();
        }

        public static void FindNext(LoadBook book)
        {
            var lVar = book.StreamReaderBook;
            while (!lVar.EndOfStream)
            {
                string line = lVar.ReadLine();
                if (line.StartsWith(partOfText))
                {
                    Console.WriteLine(line);
                    foreach (var lines in lVar.ReadToEnd())
                    { Console.Write(lines); }
                    break;
                }

            }
            book.StreamReaderBook.Close();

        }

        private static string GetPartOfText()
        {
            Console.WriteLine("Put the word which you want to find");
            string _partOfText = "Перевод";

            //string _partOfText = Console.ReadLine();
            return _partOfText;
        }

    }
}
