using System.Collections.Generic;
using BookStore.Domain.Models;

namespace BookStore.DAL.Definitions
{
    public interface IBookRepository
    {
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int bookId);
        IEnumerable<Book> GetBooks();
        Book GetBookById(int bookId);

    }
}