using System;
using System.Collections.Generic;

namespace GoodBookNook.Models
{
    // This class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public static class BookRepository
    {
        private static List<Book> books = new List<Book>();

        public static List<Book> Books { get { return books; } }
        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        public static Book GetBookByTitle(string title)
        {
            return books.Find(b => b.Title == title);
        }
    }
}
