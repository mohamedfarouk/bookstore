using BookStore.Domain;
using BookStore.Domain.Models;
using BookStore.DAL.Definitions;

namespace BookStore.BLL
{
    public class BookServices : IBookServices
    {
        IBookRepository BookRepository;
        public BookServices(IBookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public int AddBook(Book book)
        {
            var bookId = BookRepository.AddBook(book);
            return bookId;
        }

        public int DeleteBook(int bookId)
        {
            var deleteCount = BookRepository.DeleteBook(bookId);
            return deleteCount;
        }

        public Book GetBookById(int bookId)
        {
            var book = BookRepository.GetBookById(bookId);
            return book;
        }

        public int UpdateBook(int bookId, Book book)
        {
            book.ID = bookId;
             var updateCount = BookRepository.UpdateBook(book);
            return updateCount;
        }
    }
}