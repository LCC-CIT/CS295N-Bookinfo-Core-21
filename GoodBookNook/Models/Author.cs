using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Author
    {
        private List<Book> books = new List<Book>();
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public List<Book> Books {get { return books;} }
    }
}
