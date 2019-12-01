namespace GoodBookNook.Models
{
    public class User
    {
        /* private List<Review> reviews = new List<Review>();
        private List<Comment> comments = new List<Comment>();
        */
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // These properties were ignored by EF because they would cause a many-to-many relationship!
       /* public List<Review> Reviews {get { return reviews; } }
        public List<Comment> Comments { get { return comments; } }
        */

        /* I had already created these relationships:
         *   Many Reviews to one User (in the Review model)
         *   Many Comments to one User (in the Comments model)
         * By adding the List above would create these relationships:
         *   One User to many Reviews
         *   One User to many Comments
         * This would result in many-to-many relationships between:
         *   User and Review
         *   User and Comments
         */ 
    }
}
