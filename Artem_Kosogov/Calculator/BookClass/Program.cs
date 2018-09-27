using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(@"Please, enter title, author and content of the book using "","" as a separator");
            string temp = Console.ReadLine();
            string[] buf = temp.Split(',');
            Title title = new Title();
            title.title = buf[0];
            Author author = new Author();
            author.author = buf[1];
            Content content = new Content();
            content.content = buf[2];
            book.AddBook(title.title, author.author, content.content);
            book.Show(title, author, content);
            Console.ReadLine();

        }
    }
}
