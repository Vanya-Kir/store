namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of programming", "ISBN 123", "D. Knuth"),
        new Book(2, "Refactoring", "ISBN 2345", "M. Fowler"),
        new Book(3, "Clean Code", "ISBN 9870", "M. Fowler"),
    };

    public Book[] GetAllByAuthorOrTitle(string authorOrTitle)
    {
        throw new NotImplementedException();
    }

    public Book[] GetAllByIsbn(string isbn)
    {
        throw new NotImplementedException();
    }

    public Book[] GetAllByTitle(string titlePart)
    {
        return books.Where(book => book.Title.Contains(titlePart)).ToArray();
    }
}
