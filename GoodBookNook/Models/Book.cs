using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoodBookNook.Models
{
    public class Book
    {
        public int BookID { get; set; }
        private List<Author> authors = new List<Author>();
        private List<Review> reviews = new List<Review>();

        [StringLength(100, MinimumLength = 2)]  
        [Required]
        public string Title { get; set; }
        // TODO: format this property to just display year
        public DateTime PubDate { get; set; }

        // ICollection is more flexible than List and can be modified. IEnumerable can't be modified
        public ICollection<Author> Authors { get { return authors; } }
        public ICollection<Review> Reviews { get { return reviews; } }
    }
}
