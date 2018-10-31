using GoodBookNook.Models;
using System.Collections.Generic;

namespace GoodBookNook.Repositories
{
    public interface IBookRepository
    {
        List<Book> Books { get; }
        void AddBook(Book book);
        Book GetBookByTitle(string title);
    }
}