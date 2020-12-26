using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Domain.Models;
using BookStore.Domain;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {

        [Route("book/{bookId}")]
        [HttpGet]
        public Book GetBookById([FromServices] IBookServices bookServices, [FromRoute] int bookId)
        {
            return bookServices.GetBookById(bookId);
        }

        [Route("book")]
        [HttpPut]
        public IActionResult AddBook([FromServices] IBookServices bookServices, Book book)
        {
            var success = bookServices.AddBook(book);
            if(success)
                return Created($"/api/books/book/{book.ID}", book);
            else
                return NotFound();
        }

        [Route("book/{bookId}")]
        [HttpPost]
        public IActionResult UpdateBook([FromServices] IBookServices bookServices, [FromRoute] int bookId, Book book)
        {
            var success = bookServices.UpdateBook(bookId, book);
            if(success)
                return Ok();
            else
                return NotFound();
        }

        [Route("book/{bookId}")]
        [HttpDelete]
        public IActionResult DeleteBook([FromServices] IBookServices bookServices, [FromRoute] int bookId)
        {
            var success = bookServices.DeleteBook(bookId);
            if(success)
                return Ok();
            else
                return NotFound();
        }
    }
}