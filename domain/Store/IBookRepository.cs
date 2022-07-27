namespace Store;
interface IBookRepository
{
    Book[] GetAllByTitle(string titlePart);

}