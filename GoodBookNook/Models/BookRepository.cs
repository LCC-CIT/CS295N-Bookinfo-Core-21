using System;
using System.Collections.Generic;

namespace GoodBookNook.Models
{
    public static class BookRepository
    {
        private static List<Book> books = new List<Book>();

        public static IEnumerable<Book> Books { get { return Books; } }
        public static void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
