using DotNetWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static readonly List<Book> Books =
        [
            new Models.Book { Id = 1, Title = "The Round Cube", Author = "Yash Bansod", PublishedDate = new DateTime(2024, 6, 4) },
            new Models.Book { Id = 2, Title = "1984", Author = "George Orwell", PublishedDate = new DateTime(1949, 6, 8) },
            new Models.Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedDate = new DateTime(1960, 7, 11) }
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(Books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            book.Id = Books.Max(b => b.Id) + 1;
            Books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }
    }
}
