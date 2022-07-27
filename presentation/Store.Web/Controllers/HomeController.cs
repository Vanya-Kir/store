using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HomeController : ControllerBase
{
    private readonly IBookRepository bookRepository;

    public HomeController(IBookRepository bookRepository)
    {
        this.bookRepository = bookRepository;
    }

    [HttpGet]
    public IEnumerable<Book> Get(string query)
    {
        var books = bookRepository.GetAllByTitle(query);
        return books;
    }
}