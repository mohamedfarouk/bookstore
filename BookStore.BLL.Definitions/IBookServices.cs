using BookStore.BLL.Definitions.Models;

namespace BookStore.BLL.Definitions
{
    public interface IBookServices
    {
        Book GetBookById(int id);
        bool AddBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(int id);
    }
}