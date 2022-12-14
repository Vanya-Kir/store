namespace Store;

public class BookService
{
    private readonly IBookRepository bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        this.bookRepository = bookRepository;
    }

    public Book[] GetAllByQuery(string query)
    {
        if (Book.IsIsbn(query))
            return bookRepository.GetByIsbn(query);

        return bookRepository.GetAllByAuthorOrTitle(query);
    }
}