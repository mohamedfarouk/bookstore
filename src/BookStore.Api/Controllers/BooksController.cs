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
        [Route("")]
        [HttpGet]
        public IActionResult GetBookById([FromServices] IBookServices bookServices)
        {
            var books = bookServices.GetBooks();
            return new JsonResult(books);
        }


        [Route("book/{bookId}")]
        [HttpGet]
        public IActionResult GetBookById([FromServices] IBookServices bookServices, [FromRoute] int bookId)
        {
            var book = bookServices.GetBookById(bookId);
            if(book == null)
                return NotFound();

            return new JsonResult(book);
        }

        [Route("book")]
        [HttpPost]
        public IActionResult AddBook([FromServices] IBookServices bookServices, Book book)
        {
            var bookId = bookServices.AddBook(book);
            if(bookId > 0)
                return Created($"/api/books/book/{book.ID}", book);
            else
                return NotFound();
        }

        [Route("book/{bookId}")]
        [HttpPut]
        public IActionResult UpdateBook([FromServices] IBookServices bookServices, [FromRoute] int bookId, Book book)
        {
            var updateCount = bookServices.UpdateBook(bookId, book);
            if(updateCount > 0)
                return Ok();
            else
                return NotFound();
        }

        [Route("book/{bookId}")]
        [HttpDelete]
        public IActionResult DeleteBook([FromServices] IBookServices bookServices, [FromRoute] int bookId)
        {
            var deleteCount = bookServices.DeleteBook(bookId);
            if(deleteCount > 0)
                return Ok();
            else
                return NotFound();
        }
    }
}