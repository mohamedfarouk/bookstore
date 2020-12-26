using System.Collections.Generic;
using BookStore.Domain.Models;

namespace BookStore.Domain
{
    public interface IBookServices
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int bookId);
        int AddBook(Book book);
        int UpdateBook(int bookId, Book book);
        int DeleteBook(int bookId);
    }
}