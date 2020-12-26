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
            throw new System.NotImplementedException();
        }

        public int DeleteBook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public Book GetBookById(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}