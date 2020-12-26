using BookStore.Domain.Models;

namespace BookStore.Domain
{
    public interface IBookServices
    {
        Book GetBookById(int bookId);
        bool AddBook(Book book);
        bool UpdateBook(int bookId, Book book);
        bool DeleteBook(int bookId);
    }
}