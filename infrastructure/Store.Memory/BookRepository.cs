namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of programming", "ISBN 123 456 798-0", "D. Knuth"),
        new Book(2, "Refactoring", "ISBN 98-76 543 210", "M. Fowler"),
        new Book(3, "Clean Code", "ISBN 123-456-7890-123", "M. Fowler"),
    };

    public Book[] GetAllByAuthorOrTitle(string authorOrTitle)
    {
        return books.Where(book => book.Author.Contains(authorOrTitle)
                                || book.Title.Contains(authorOrTitle))
                    .ToArray();
    }

    public Book[] GetByIsbn(string isbn)
    {
        return books.Where(book => book.Isbn == isbn).ToArray();
    }

}
