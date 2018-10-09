using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2._5.Classes;

//Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать
//одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
//содержание.

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(new Author("London"), new Title("Hearts of Three"), new Content("Love..."));
            Book book2 = new Book(new Author("King"), new Title("The Dark Tower"), new Content("Horror..."));

            book1.showBook();
            Console.WriteLine(new string('-', 35));
            book2.showBook();
            Console.WriteLine(new string('-', 35));
            Title title = new Title("Balda");
            Author author = new Author("Pushkin");
            Content content = new Content("Fairy tale");
            Book book3 = new Book(author, title, content);
            book3.showBook();

            Console.ReadKey();
        }
    }
}
