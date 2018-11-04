using System;
using System.Collections.Generic;

namespace GoodBookNook.Models
{
    public class Book
    {
        private List<Author> authors = new List<Author>();
        private List<Review> reviews = new List<Review>();

        public int BookID { get; set; }     // This will become the Primary Key for the table
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public List<Author> Authors { get { return authors; } }
        public List<Review> Reviews { get { return reviews; } }
    }
}
