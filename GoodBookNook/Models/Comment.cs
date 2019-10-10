
namespace GoodBookNook.Models
{
    public class Comment
    {
        public string CommentText { get; set; }
        public User UserName { get; set; }
        public Review UserReview { get; set; }
    }
}
