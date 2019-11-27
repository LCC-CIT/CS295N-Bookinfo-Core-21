using GoodBookNook.Models;
using System.Collections.Generic;

namespace GoodBookNook.Repositories
{
    // This is class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public class FakeBookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        public List<Book> Books { get { return books; } }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBookByTitle(string title)
        {
            Book book = books.Find(b => b.Title == title);
            return book;
        }

    }
}