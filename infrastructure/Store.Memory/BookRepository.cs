namespace Store.Memory;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of programming"),
        new Book(2, "Refactoring"),
        new Book(3, "Clean Code"),
    };
    public Book[] GetAllByTitle(string titlePart)
    {
        return books.Where(book => book.Title.Contains(titlePart)).ToArray();
    }
}
