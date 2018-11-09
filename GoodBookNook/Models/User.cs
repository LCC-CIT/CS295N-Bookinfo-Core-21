using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{

    public class User
    {

        private List<Review> reviews = new List<Review>();
        private List<Comment> comments = new List<Comment>();

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Review> Reviews {get { return reviews; } }
        public ICollection<Comment> Comments { get { return comments; } }

    }
}
