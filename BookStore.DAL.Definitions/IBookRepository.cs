using System;
using BookStore.Domain.Models;

namespace BookStore.DAL.Definitions
{
    public interface IBookRepository
    {
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int bookId);
        Book GetBookById(int bookId);

    }
}