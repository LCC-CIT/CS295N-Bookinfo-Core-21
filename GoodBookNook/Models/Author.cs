using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodBookNook.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
