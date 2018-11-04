using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

// Создать статический класс FindAndReplaceManager с методом void FindNext(string str) 
//для поиска по книге.При вызове этого метода, производится последовательный поиск 
//строки в книге. (Книга любая, подгружаем с помощью Filestream)

namespace Task6._2
{
    public static class FindAndReplaceManager
    {
        public static bool FindNext(string page, string str, int i)
        {
            bool result = page.Contains(str);
            if (result)
            {
                Console.WriteLine($"The substring {str} is present on page {i}");
                Console.WriteLine($"{str} begins at character position {page.IndexOf(str)}");
            }
            return result;
        }

        public static string[] OpenPDFFile(string path)
        {
            try
            {
                using (PdfReader reader = new PdfReader(path))
                {
                    string[] page = new string[reader.NumberOfPages + 1];
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        //парсим книгу постранично
                        page[i] = PdfTextExtractor.GetTextFromPage(reader, i);
                    }
                    return page;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read\n" + ex.Message);
                return new string[] {};
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //строка для поиска
            string findString = "привет";
            //флаг совпадений
            bool contains = false;
            //создаем массив страниц
            string[] text = FindAndReplaceManager.OpenPDFFile("book.pdf");
            for (int i = 1; i < text.Length; i++)
            {
                if (FindAndReplaceManager.FindNext(text[i], findString, i))
                    contains=true;
            }
            //Если не было совпадений, то сообщаем об этом
            if (!contains && text.Length != 0)
                Console.WriteLine("There were no matches");

            Console.ReadKey();
        }
    }
}
