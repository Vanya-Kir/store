namespace Store;
public class Book
{
    public Book(int id, string title, string isbn, string author)
    {
        Id = id;
        Title = title;
        Isbn = isbn;
        Author = author;
    }

    public int Id { get; }
    public string Title { get; }
    public string Isbn { get; }
    public string Author { get; }
}
