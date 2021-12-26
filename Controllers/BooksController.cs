using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public List<Book> books = new List<Book>()
       {

new Book {Id= 1, Title = "Sesher Kobiti", Author= "Rabindranath", PublicationYear = 2021, CallNumber = "Fatra" },
new Book {Id= 2, Title = "Ager Kobita", Author= "Raju", PublicationYear = 1921, CallNumber = "Valo" },
new Book {Id= 3, Title = "Padma Nadir Majhi", Author= "Emdad", PublicationYear = 2002, CallNumber = "Normal" },
new Book {Id= 4, Title = "Hajar Bachar Dhore", Author= "Shaon", PublicationYear = 1990, CallNumber = "Avg" },
new Book {Id= 5, Title = "Roktatto Prantor", Author= "Tarek", PublicationYear = 1980, CallNumber = "Fatra" },
new Book {Id= 6, Title = "Hoimonty", Author= "Krishno", PublicationYear = 2011, CallNumber = "Normal" },
new Book {Id= 7, Title = "Bilashi", Author= "Dipto", PublicationYear = 2001, CallNumber = "Good" }

};ss
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books;
        }

        [HttpGet ("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }



    }
}
