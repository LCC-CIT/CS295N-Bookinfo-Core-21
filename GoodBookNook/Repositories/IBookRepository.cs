using GoodBookNook.Models;
using System.Linq;

namespace GoodBookNook.Repositories
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
        void AddBook(Book book);
        void AddReview(Book book, Review review);
        Book GetBookByTitle(string title);
    }
}