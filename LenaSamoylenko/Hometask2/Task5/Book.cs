using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Book
    {

        Title title = null;
        Autor autor = null;
        Content content = null;

        internal Title Title => title;
        internal Autor Autor => autor;
        internal Content Content => content;
        public Book(string autor, string title, string content)
        {
            this.autor = new Autor(autor);
            this.title = new Title(title);
            this.content = new Content(content);
        }

    }
    class Books
    {
        List<Book> books;
        public Books()
        {
            books = new List<Book>();
        }

        public void addBook(string autor, string title, string content)
        {
            Book bookTemp = new Book(autor, title, content);
            books.Add(bookTemp);
        }
        private void Show(Autor a, Title t, Content c)
        {
            a.Show();
            t.Show();
            c.Show();
        }
        public void Print()
        {
            foreach (Book book in books)
            {
                Show(book.Autor, book.Title, book.Content);
            }
        }


    }
}
