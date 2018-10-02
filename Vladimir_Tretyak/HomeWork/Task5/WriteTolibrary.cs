using System;

namespace Task5
{
    class WriteTolibrary
    {
        string Title;
        string Author;
        string Content;
        Books library = new Books();
        public void write()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Введите название новой книги : ");
                Title = Console.ReadLine();
                Console.WriteLine("Введите название автора : ");
                Author = Console.ReadLine();
                Console.WriteLine("Введите содержание книги : ");
                Content = Console.ReadLine();
                Book newBook = new Book(Title,Author,Content);
                library.inputUserData(newBook);
                Console.WriteLine("Для окончания ввода нажмите Esc, для продолжения Enter");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Clear();                     
        }
        public void Show()
        {
            foreach (var b in library.books)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine($"Название книги - {b.Title}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Автор книги - {b.Author}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Содержание книги - {b.Content}");
                Console.WriteLine();
            }
        }
    }
}
