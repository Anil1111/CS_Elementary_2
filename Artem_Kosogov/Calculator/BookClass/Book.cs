using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Book
    {
        public void AddBook(string title, string author, string content)
        {
            Title bookTitle = new Title();
            Author bookAuthor = new Author();
            Content bookContent = new Content();
            bookTitle.title = title;
            bookAuthor.author = author;
            bookContent.content = content; 
        }

        public void Show(Title title, Author author, Content content)
        {
            title.Show();
            author.Show();
            content.Show();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
