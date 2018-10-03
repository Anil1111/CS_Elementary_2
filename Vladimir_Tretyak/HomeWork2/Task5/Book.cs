namespace Task5
{
    class Book
    {
        string title = null;
        string author = null;
        string content = null;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }

        public Book(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
    }  
}
