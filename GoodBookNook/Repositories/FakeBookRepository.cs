using GoodBookNook.Models;
using System;
using System.Collections.Generic;

namespace GoodBookNook.Repositories
{
    public  class FakeBookRepository : IBookRepository
    {
        private  List<Book> books = new List<Book>();
        public  List<Book> Books { get { return books; } }


        public  void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddReview(Book book, Review review)
        {
            book.Reviews.Add(review);
        }

        public  Book GetBookByTitle(string title)
        {
            Book book = books.Find(b => b.Title == title);
            return book;
        }

    }
}
