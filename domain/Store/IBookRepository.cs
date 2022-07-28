namespace Store;
public interface IBookRepository
{
    Book[] GetByIsbn(string isbn);

    Book[] GetAllByAuthorOrTitle(string authorOrTitle);

}