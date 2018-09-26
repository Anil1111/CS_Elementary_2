using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Book
    {
        private string book = null;
        public string bookProperties
        {
            get { return book; }
            set { book = value; }

        }

        public void addBook(string autor, string title, string content)
        {
            Autor autorBook1 = new Autor();
            autorBook1.autorProperties = autor;
            Title titleBook1 = new Title();
            titleBook1.titleProperties = title;
            Content contentBook1 = new Content();
            contentBook1.contentProperties = content;
            Show(autorBook1, titleBook1, contentBook1);

        }
        internal void Show(Autor a, Title t, Content c)
        {
            a.Show();
            t.Show();
            c.Show();
        }

        public string putData(string massege)
        {
            Console.WriteLine($"{massege}");
            return (Console.ReadLine());
        }
    }
}
