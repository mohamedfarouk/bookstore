using System;
using System.Collections.Generic;
using BookStore.DAL.Definitions;
using BookStore.Domain.Models;
using Xunit;

namespace BookStore.Tests.Helpers
{
    public class EmptyBookRepository : IBookRepository
    {
        public int AddBook(Book book) => throw new NotSupportedException();

        public int UpdateBook(Book book) => 0;

        public int DeleteBook(int bookId) => 0;

        public Book GetBookById(int bookId) => null;
    }

}
