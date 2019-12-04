using System.ComponentModel.DataAnnotations.Schema;

namespace GoodBookNook.Models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewID { get; set; }
        public string ReviewText { get; set; }

        // EF will use this property to create the ReviewerUserID field in the Reviews Table
        public User Reviewer { get; set; }
    }
}
