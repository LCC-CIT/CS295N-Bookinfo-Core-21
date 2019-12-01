namespace GoodBookNook.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }

        // EF uses this property to create the UserNameUserID FK field in the Comments table.
        public User UserName { get; set; }

        // EF uses this property to create the UserReviewReviewID field in the Comments table.
        public Review UserReview { get; set; }
    }
}
