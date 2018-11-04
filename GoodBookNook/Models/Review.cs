namespace GoodBookNook.Models
{
    public class Review
    {
        public int ReviewID { get; set; }       // This will become the PK
        public string ReviewText { get; set; }
        public User Reviewer { get; set; }
    }
}
