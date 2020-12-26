using System.Linq;
using System.Threading;
using System.Collections.Generic;
using BookStore.Domain.Models;
using BookStore.DAL.Definitions;

namespace BookStore.DAL
{
    public class BookRepository : IBookRepository
    {
        static int BookId = 0;
        static Dictionary<int, Book> Books = new Dictionary<int, Book>();

        static BookRepository()
        {
            var currentBookId = ++BookId;
            Books.Add(currentBookId, new Book {
                    ID = currentBookId,
                    Title = "Harry Potter And the Chamber of Secrets",
                    Description = "Harry Potter And the Chamber of Secrets",
                    Author = "J.K. Rowling",
                    CoverImageUri = "https://upload.wikimedia.org/wikipedia/en/c/c0/Harry_Potter_and_the_Chamber_of_Secrets_movie.jpg",
                    Price = 10M
            });

            currentBookId = ++BookId;
            Books.Add(currentBookId, new Book {
                    ID = currentBookId,
                    Title = "Harry Potter and The Order of The Phoenix",
                    Description = "Harry Potter and The Order of The Phoenix",
                    Author = "J.K. Rowling",
                    CoverImageUri = "https://upload.wikimedia.org/wikipedia/en/e/e7/Harry_Potter_and_the_Order_of_the_Phoenix_poster.jpg",
                    Price = 10M
            });
        }
        public int AddBook(Book book)
        {
            var currentBookId = Interlocked.Increment(ref BookId);
            book.ID = BookId;
            Books.Add(currentBookId, book);
            return book.ID;
        }

        public int UpdateBook(Book book)
        {
            if(!Books.ContainsKey(book.ID))
                return 0;

            Books[book.ID] = book;
            return 1;
        }

        public int DeleteBook(int bookId)
        {
            if(!Books.ContainsKey(bookId))
                return 0;

            Books.Remove(bookId);
            return 1;
        }

        public IEnumerable<Book> GetBooks()
        {
            return Books.Values.AsEnumerable();
        }

        public Book GetBookById(int bookId)
        {
            if(!Books.ContainsKey(bookId))
                return null;

            return Books[bookId];
        }
    }
}