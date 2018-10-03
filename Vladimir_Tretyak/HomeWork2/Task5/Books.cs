using System.Collections.Generic;

namespace Task5
{
    class Books
    {
        public List<Book> books;

        public Books()
        {
            books = new List<Book>();
        }
        public void inputUserData(Book newBook)//Добавляем элементы в список 
        {
            books.Add(newBook);
        }

    }
}
