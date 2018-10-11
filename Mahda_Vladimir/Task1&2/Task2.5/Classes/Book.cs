using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5.Classes
{
    class Book
    {
        Author author;
        Title title;
        Content content;

        public Book(Author author, Title title, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public void showBook()
        {
            Console.Write("Author  : "); author.ShowAuthor();
            Console.Write("Title   : ");  title.showTitle();
            Console.Write("Content : "); content.showContent();
        }
    }
}
