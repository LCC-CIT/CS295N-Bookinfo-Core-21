using GoodBookNook.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GoodBookNook.Repositories
{
    public  class BookRepository : IBookRepository
    {
        private AppDbContext context;
        // IQuerable objects can pass on a query to the Db instead of returing a colleciton that has to be filtered
        public  IQueryable<Book> Books { get { return context.Books.Include("Authors").Include("Reviews"); } }

         public BookRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public  void AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void AddReview(Book book, Review review)
        {
            book.Reviews.Add(review);
            context.Books.Update(book);
            context.SaveChanges();
        }

        public  Book GetBookByTitle(string title)
        {
            Book book;
            book = context.Books.First(b => b.Title == title);
            return book;
        }

    }
}
