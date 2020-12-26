using System;
using BookStore.Domain.Models;
using BookStore.DAL.Definitions;

namespace BookStore.DAL
{
    public class BookRepository : IBookRepository
    {
        public int AddBook(Book book)
        {
            throw new System.NotImplementedException();
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