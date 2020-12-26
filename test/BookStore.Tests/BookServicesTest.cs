using System;
using Xunit;
using BookStore.BLL;
using BookStore.Tests.Helpers;
using BookStore.DAL.Definitions;
using BookStore.Domain.Models;

namespace BookStore.Tests
{
    public class BookServicesTest
    {
        [Fact]
        public void NotFoundBook_GetReturnsNull()
        {
            BookServices bookServices = new BookServices(new EmptyBookRepository());
            var book = bookServices.GetBookById(10);
            Assert.Null(book);
        }

        [Fact]
        public void NotFoundBook_DeleteReturnsZero()
        {
            BookServices bookServices = new BookServices(new EmptyBookRepository());
            var deleteCount = bookServices.DeleteBook(10);
            Assert.Equal(0, deleteCount);
        }
    }
}