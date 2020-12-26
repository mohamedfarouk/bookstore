using System;
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

        public Book GetBookById(int bookId)
        {
            if(!Books.ContainsKey(bookId))
                return null;

            return Books[bookId];
        }
    }
}