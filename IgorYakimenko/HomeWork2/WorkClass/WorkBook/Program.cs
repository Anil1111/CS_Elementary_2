using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Content = string.Empty;
            string Title = string.Empty;
            string Author = string.Empty;

            Console.Write("Введите Автора книги : ");
            Author = Console.ReadLine();

            Console.Write("Введите название книги : ");
            Title = Console.ReadLine();
            
            Console.Write("Введите краткое содержание книги : ");
            Content = Console.ReadLine();

            CContent content = new CContent(Content);
            CTitle title = new CTitle(Title);
            CAuthor author = new CAuthor(Author);

            Console.WriteLine(new string('-',50));

            CBook book = new CBook(content,title,author);
            book.Show();

            Console.ReadKey();
        }
    }
}
