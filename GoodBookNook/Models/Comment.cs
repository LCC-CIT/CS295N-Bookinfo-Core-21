namespace GoodBookNook.Models
{
    public class Comment
    {
        public int CommentID { get; set; }      // This will become the PK
        public string CommentText { get; set; }
        public User UserName { get; set; }
        public Review UserReview { get; set; }
    }
}
