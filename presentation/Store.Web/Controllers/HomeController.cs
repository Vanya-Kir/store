using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HomeController : ControllerBase
{
    private readonly BookService bookService;


    public HomeController(BookService bookService)
    {
        this.bookService = bookService;
    }

    [HttpGet]
    public IEnumerable<Book> Get(string query)
    {
        var books = bookService.GetAllByQuery(query);
        return books;
    }
}