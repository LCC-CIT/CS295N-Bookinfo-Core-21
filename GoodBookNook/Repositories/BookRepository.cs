using GoodBookNook.Models;
using System.Linq;
using System.Collections.Generic;

namespace GoodBookNook.Repositories
{
    public  class BookRepository : IBookRepository
    {
        private ApplicationDbContext context;
        private  List<Book> books = new List<Book>();
        public  List<Book> Books { get { return books; } }

        public BookRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public  void AddBook(Book book)
        {
            // Add the book to the database
            // Note- Update is like Add, but it only adds the item if it isn't already in the 
            context.Books.Update(book);
            // Save the book so that it gets an ID (primary key value)
            context.SaveChanges();
        }

        public  Book GetBookByTitle(string title)
        {
            Book book = context.Books.First(b => b.Title == title);
            return book;
        }


    }
}
