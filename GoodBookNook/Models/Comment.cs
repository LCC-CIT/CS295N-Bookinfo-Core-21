using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public User UserName { get; set; }
        public Review UserReview { get; set; }
    }
}
