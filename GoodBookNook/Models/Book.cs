using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Book
    {
        public int BookID { get; set; }
        private List<Author> authors = new List<Author>();
        private List<Review> reviews = new List<Review>();

        public string Title { get; set; }
        public DateTime PubDate { get; set; }

        // ICollection is more flexible than List and can be modified. IEnumerable can't be modified
        public ICollection<Author> Authors { get { return authors; } }
        public ICollection<Review> Reviews { get { return reviews; } }
    }
}
