namespace Store;
public interface IBookRepository
{
    Book[] GetByIsbn(string isbn);

    Book[] GetAllByAuthorOrTitle(string authorOrTitle);
    
    Book GetById(int id);
    Book[] GetAllByIds(IEnumerable<int> bookIds);
}