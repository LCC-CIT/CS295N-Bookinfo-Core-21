using GoodBookNook.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GoodBookNook.Repositories
{
    public  class BookRepository : IBookRepository
    {
        private AppDbContext context;
        public  List<Book> Books 
        { 
            get 
            {
                var books = context.Books.Include("Authors").Include("Reviews");
                return books.ToList<Book>(); 
            }
        }

        public BookRepository(AppDbContext ctx)
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
