using System;
using System.Collections.Generic;

namespace GoodBookNook.Models
{
    public class Author
    {
        private List<Book> books = new List<Book>();

        public int AuthorID { get; set; }       // This will become the PK
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public List<Book> Books {get { return books;} }
    }
}
