namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of programming", "ISBN 123 456 798-0", "D. Knuth", "Описание 1", 1000.98M),
        new Book(2, "Refactoring", "ISBN 98-76 543 210", "M. Fowler", "Описание 2", 2000.98M),
        new Book(3, "Clean Code", "ISBN 123-456-7890-123", "M. Fowler", "Описание 3", 3000.98M),
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

    public Book GetById(int id)
    {
        return books.Single(book => book.Id == id);
    }
}
