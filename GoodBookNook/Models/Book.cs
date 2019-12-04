using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodBookNook.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        private List<Author> authors = new List<Author>();
        private List<Review> reviews = new List<Review>();

        public string Title { get; set; }
        public DateTime PubDate { get; set; }

        // EF will use these properties to add BookID FK fields to the Authors and Reviews tables.
        public List<Author> Authors { get { return authors; } }
        public List<Review> Reviews { get { return reviews; } }
    }
}
