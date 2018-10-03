using System;
using System.Collections.Generic;

namespace GoodBookNook.Models
{
    public static class BookRepository
    {
        private static List<Book> books = new List<Book>();

        public static List<Book> Books { get { return books; } }
        public static void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
